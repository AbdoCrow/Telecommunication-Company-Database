using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public bool RegisterCustomer(string name, string address, string phone, string email, int planId,
            string username, string passwordHash)
        {
            string query = $@"
        INSERT INTO Customers (name, address, phone_number, email, service_plan_id) 
        OUTPUT INSERTED.customer_id 
        VALUES ('{name}', '{address}', '{phone}', '{email}', {planId});
    ";

            int customerId = (int)dbMan.ExecuteScalar(query);
            if (customerId > 0)
            {
                string loginQuery = $@"
            INSERT INTO Login (customer_id, username, password_hash) 
            VALUES ({customerId}, '{username}', '{passwordHash}');
        ";
                return dbMan.ExecuteNonQuery(loginQuery) > 0;
            }

            return false;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public bool LoginCustomer(string username, string passwordHash)
        {
            string query = $@"
        SELECT COUNT(*) 
        FROM Login 
        WHERE username = '{username}' AND password_hash = '{passwordHash}';
    ";
            int result = (int)dbMan.ExecuteScalar(query);
            return result > 0;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public int GetCustID(string user)
        {
            string query = $@"
        SELECT Customers.customer_id 
        FROM Customers 
        INNER JOIN Login ON Customers.customer_id = Login.customer_id
        WHERE username = '{user}';
    ";
            return (int)dbMan.ExecuteScalar(query);
        }


        ///////////////////////////////////////////////////////////////////
        public DataTable GetServicePlans()
        {
            string query = "SELECT plan_id, plan_name FROM Service_Plans";
            return dbMan.ExecuteReader(query);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public DataTable GetCustomerDetails(int customerId)
        {
            string query = $@"
        SELECT Customers.name, Customers.address, Customers.phone_number, Customers.email, 
               Customers.loyalty_points, Customers.service_plan_id, Service_Plans.plan_name
        FROM Customers
        INNER JOIN Service_Plans ON Customers.service_plan_id = Service_Plans.plan_id
        WHERE Customers.customer_id = {customerId};
    ";
            return dbMan.ExecuteReader(query);
        }

        
        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Get subscribed services and usage
        public DataTable GetCustomerUsage(int customerId)
        {
            string query = $@"
                        SELECT 
                        data_used, 
                        minutes_used, 
                        sms_sent 
                    FROM Service_Usage
                    WHERE customer_id = {customerId}
                    ";

            return dbMan.ExecuteReader(query);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Upgrade or downgrade service plan
        public bool UpdateServicePlan(int customerId, int newPlanId)
        {
            string query = $@"
        UPDATE Customers 
        SET service_plan_id = {newPlanId} 
        WHERE customer_id = {customerId};
        ";
            return dbMan.ExecuteNonQuery(query) > 0;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Get loyalty points and rewards
        public int GetLoyaltyPoints(int customerId)
        {
            string query = $@"
        SELECT loyalty_points 
        FROM Customers 
        WHERE customer_id = {customerId};
        ";
            return (int)dbMan.ExecuteScalar(query);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public bool RedeemLoyaltyPoints(int customerId, int pointsToRedeem)
        {
            string query = $@"
        UPDATE Customers 
        SET loyalty_points = loyalty_points - {pointsToRedeem} 
        WHERE customer_id = {customerId};
        ";
            return dbMan.ExecuteNonQuery(query) > 0;
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Get billing information
        public DataTable GetBillingInfo(int customerId)
        {
            string query = $@"
        SELECT amount, payment_date, payment_method, status 
        FROM Payments 
        WHERE customer_id = {customerId};
        ";
            return dbMan.ExecuteReader(query);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        //show price
        public decimal GetPrice(int PlanID)
        {
            string query = $@"Select price
                              From Service_Plans
                              WHERE plan_id = {PlanID}  ";
            object price = dbMan.ExecuteScalar(query);
            if (price != null)
            {

                return Convert.ToDecimal(price);
            }
            else
            {
                return 0;
            }

            //return Convert.ToInt32(price);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Submit service issues
        //////DEH 8ALAT!!!!!
        public bool AddComplaint(int customerId, string complaintType)
        {
            string complaintQuery = $@"
        INSERT INTO Complaint (customer_id, complaint_date, complaint_type) 
        VALUES ({customerId}, GETDATE(), '{complaintType}');";

            return dbMan.ExecuteNonQuery(complaintQuery) > 0;

        }


        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        // Submit feedback
        public bool AddFeedback(int customerId, string feedbackText, int rating)
        {
            string feedbackQuery = $@"
                INSERT INTO Feedback (customer_id, service_feedback, rating, feedback_date) 
                VALUES ({customerId}, '{feedbackText}', {rating}, GETDATE());";
            return dbMan.ExecuteNonQuery(feedbackQuery) > 0;

        }

        public DataTable GetCustomerComplaints(int customerId)
        {
            string query = $@"
                SELECT complaint_date,complaint_type 
                FROM Complaint 
                WHERE customer_id = {customerId}
                ORDER BY complaint_date DESC";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCustomerFeedbacks(int customerId)
        {
            string query = $@"
                    SELECT 
                        feedback_id, 
                        service_feedback, 
                        rating, 
                        feedback_date
                    FROM Feedback
                    WHERE customer_id = {customerId}
                    ORDER BY feedback_date DESC";


            return dbMan.ExecuteReader(query);

        }

        ////////////////////////////////////////////////////////////////////////////////
        /// CALL MESSAGES AND POINTS GAINED!
        ////////////////////////////////////////////////////////////////////////////////
        public bool AddSMS(int customerId, string recipientNumber)
        {
            string SMS = $@"
        INSERT INTO Customer_Actions (customer_id, action_type, recipient_number)
        VALUES ({customerId}, 'SMS', '{recipientNumber}');";
            dbMan.ExecuteNonQuery(SMS);
            if (!UsageRecordExists(customerId))
            {

                InsertNewUsage(customerId);
            }
            UpdateUsage(customerId, 0, 1);

            int pointsToAdd = CalculateLoyaltyPoints("SMS", 0); // Duration is irrelevant for SMS
            return UpdateLoyaltyPoints(customerId, pointsToAdd);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public bool AddCall(int customerId, string recipientNumber, int durationSeconds)
        {
            string CALL = $@"
        INSERT INTO Customer_Actions (customer_id, action_type, recipient_number, duration_seconds)
        VALUES ({customerId}, 'Call', '{recipientNumber}', {durationSeconds});";
            dbMan.ExecuteNonQuery(CALL);
            if (!UsageRecordExists(customerId))
            {

                InsertNewUsage(customerId);
            }
            UpdateUsage(customerId, durationSeconds / 60, 0);
            int pointsToAdd = CalculateLoyaltyPoints("Call", durationSeconds);

            return UpdateLoyaltyPoints(customerId, pointsToAdd);
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public bool UpdateLoyaltyPoints(int customerId, int pointsToAdd)
        {
            string query = $@"
        UPDATE Customers
        SET loyalty_points = loyalty_points + {pointsToAdd}
        WHERE customer_id = {customerId};";
            return dbMan.ExecuteNonQuery(query) > 0; //to check law 7sl t3deel
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        public int CalculateLoyaltyPoints(string actionType, int durationSeconds)
        {
            if (actionType == "Call")
            {
                return 10 * (durationSeconds / 60);
            }
            else if (actionType == "SMS")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool VerifyRecipient(string phoneNumber)
        {
            string query = $"SELECT COUNT(*) FROM Customers WHERE phone_number = '{phoneNumber}'";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }

        public DataTable GetCallHistory(int customerId)
        {
            string query = $@"
        SELECT 
            action_type,
            recipient_number,
            action_timestamp,
            duration_seconds
        FROM Customer_Actions
        WHERE customer_id = {customerId} AND action_type= 'Call'
        ORDER BY action_timestamp DESC";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetSMSHistory(int customerId)
        {
            string query = $@"
        SELECT 
            action_type,
            recipient_number,
            action_timestamp
        FROM Customer_Actions
        WHERE customer_id = {customerId} AND action_type= 'SMS'
        ORDER BY action_timestamp DESC";

            return dbMan.ExecuteReader(query);
        }
        /// to update or insert the data for the usage 
        public bool UpdateUsage(int customerId, int minutesUsed, int smsSent)
        {
            string query = $@"
                UPDATE Service_Usage
                SET minutes_used = minutes_used + {minutesUsed}, sms_sent = sms_sent + {smsSent}
                WHERE customer_id = {customerId} ;";
            return dbMan.ExecuteNonQuery(query) > 0;
        }
        private void InsertNewUsage(int customerId)
        {
            string query = $@"
        INSERT INTO Service_Usage (customer_id, data_used, minutes_used, sms_sent) 
        VALUES ({customerId}, 0, 0, 0)";
            dbMan.ExecuteNonQuery(query);
        }
        private bool UsageRecordExists(int customerId)
        {
            string query = $"SELECT COUNT(*) FROM Service_Usage WHERE customer_id = {customerId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        ////////////////////////////////////////////////////////////////////////////////
        /// ORDERS!
        ////////////////////////////////////////////////////////////////////////////////
        public DataTable GetCustomerPayments(int customerId)
        {
            string query =
                $"SELECT payment_id, amount, payment_method, status FROM Payments WHERE customer_id = {customerId} AND status = 'Completed'";
            return dbMan.ExecuteReader(query);
        }

        public decimal GetItemPrice(int inventoryId)
        {
            string query = $"SELECT price FROM Inventory WHERE inventory_id = {inventoryId}";
            object result = dbMan.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            else
            {
                return 0;
            }
        }

        public DataTable GetInventory()
        {
            string query = @"SELECT inventory_id, item_name, quantity, price, status  
                         FROM Inventory 
                         WHERE quantity > 0 AND status = 'Available'";
            return dbMan.ExecuteReader(query);
        }

        public int AddPayment(int customerId, decimal amount, string paymentMethod)
        {
            string query = $@"
        INSERT INTO Payments (customer_id, amount, payment_method, status, payment_date)
        VALUES ({customerId}, {amount}, '{paymentMethod}', 'Completed', GETDATE());
        SELECT SCOPE_IDENTITY();";

            object result = dbMan.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1;
            }

        }
        public string PurchaseItem(int customerId, int inventoryId, int quantity, int paymentId)
        {
            //Get item price and available quantity
            string itemQuery = $"SELECT price, quantity FROM Inventory WHERE inventory_id = {inventoryId}";
            DataTable itemResult = dbMan.ExecuteReader(itemQuery);

            if (itemResult == null || itemResult.Rows.Count == 0)
            {
                return "Item not found.";
            }

            decimal itemPrice = Convert.ToDecimal(itemResult.Rows[0]["price"]);
            int availableQuantity = Convert.ToInt32(itemResult.Rows[0]["quantity"]);

            //Check if sufficient quantity is available
            if (availableQuantity < quantity)
            {
                return "Insufficient quantity available.";
            }

            //Get payment amount
            string paymentQuery = $"SELECT amount FROM Payments WHERE payment_id = {paymentId} AND customer_id = {customerId} AND status = 'Completed'";
            object paymentAmountObj = dbMan.ExecuteScalar(paymentQuery);

            if (paymentAmountObj == null)
            {
                return "";
            }

            decimal paymentAmount = Convert.ToDecimal(paymentAmountObj);

            //Check if payment is sufficient
            if (paymentAmount < itemPrice * quantity)
            {
                return "Insufficient payment amount.";
            }

            //Update inventory
            string updateInventoryQuery = $"UPDATE Inventory SET quantity = quantity - {quantity} WHERE inventory_id = {inventoryId}";
            dbMan.ExecuteNonQuery(updateInventoryQuery);

            // Create purchase order
            string orderQuery = $"INSERT INTO Purchase_Orders (customer_id, inventory_id, quantity, order_status) VALUES ({customerId}, {inventoryId}, {quantity}, 'Completed')";
            dbMan.ExecuteNonQuery(orderQuery);

            // Deduct payment amount
            string updatePaymentQuery = $"UPDATE Payments SET amount = amount - {itemPrice * quantity} WHERE payment_id = {paymentId}";
            dbMan.ExecuteNonQuery(updatePaymentQuery);

            return "Purchase successful.";
        }

        public DataTable PurchaseHistory(int item, int CUSTID)
        {
            string itemQuery = $@"
                    SELECT 
                        i.item_name,
                        po.quantity,
                        i.price,
                        po.order_status,
                        p.payment_method,  
                        p.payment_date   
                    FROM Purchase_Orders po
                    INNER JOIN Inventory i ON po.inventory_id = i.inventory_id
                    LEFT JOIN Payments p ON po.customer_id = p.customer_id  
                    WHERE po.customer_id = {CUSTID}";
            DataTable itemResult = dbMan.ExecuteReader(itemQuery);
            return itemResult;
        }
        ////////////////////////////////////////////////////////////////////////////////
        /// Loyality REDEEM!
        ////////////////////////////////////////////////////////////////////////////////
       

        public bool RedeemReward(int customerId, string reward)
        {
                int pointsRequired = GetPointsForReward(reward);
                string deductPointsQuery = $@"
            UPDATE Customers 
            SET loyalty_points = loyalty_points - {pointsRequired} 
            WHERE customer_id = {customerId}";
                dbMan.ExecuteNonQuery(deductPointsQuery);

                int dummy = 1; //this should be the loyality status of the customer depending on the amount he spend but the scope is too big for us
                string redemptionQuery = $@"
            INSERT INTO Loyalty_Redemptions (customer_id, loyalty_id, points_redeemed, reward)
            VALUES ({customerId}, 
                    {dummy}, 
                    {pointsRequired}, 
                    '{reward}')";
                dbMan.ExecuteNonQuery(redemptionQuery);

                //here we should apply the reward but the scope of this project is already big enough :(

                return true;
            
        }
        //get points required for each reward same logic as the one in the form !!!
        private int GetPointsForReward(string reward)
        {
            switch (reward)
            {
                case "20 free SMS": return 50;
                case "10 min for free": return 30;
                case "30% Discount of Phones": return 100;
                case "20% Discount on Plan": return 80;
                default: return 0;
            }
        }

        //////////////////////////////////////////////
        //////////////////////////////////////////////
        public DataTable GetComplaintDetails(int cId)
        {
            string query = $@"
        SELECT *
        FROM Complaint
        WHERE complaint_id = {cId};
    ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAllComplaintDetails()
        {
            string query = $@"
        SELECT *
        FROM Complaint
        ORDER BY complaint_date;
    ";
            return dbMan.ExecuteReader(query);
        }
        public void solvecomplaint(int cid)
        {
            string query = $"DELETE FROM Complaint WHERE complaint_id={cid};";
            dbMan.ExecuteNonQuery(query);
        }
        public bool tchnexist(int id)
        {
            string query = $@"
        SELECT COUNT(*) 
        FROM Employees 
        WHERE employee_id={id};
    ";
            int result = (int)dbMan.ExecuteScalar(query);
            return result > 0;
        }

        public DataTable getNetworkIssues(int tchn_id)
        {
            string query = $@"
        SELECT n.issue_id, n.tower_id, n.issue_type, n.reported_date
        FROM Network_Issues n, Employees e, Tower_Assignments a
        Where e.employee_id={tchn_id} AND e.employee_id=a.employee_id AND a.tower_id=n.tower_id;
    ";
            return dbMan.ExecuteReader(query);
        }
        public void ResolveNetworkIssue(int towerid, string resolve)
        {
            string query = $@"UPDATE Network_Issues
            SET resolved_date='2024-12-28', resolution_summary='{resolve}'
            WHERE tower_id={towerid};";
            dbMan.ExecuteNonQuery(query);
        }
        //public decimal Getoldprice(int serviceid)
        //{
        //    string query = $"SELECT price FROM Service_Plans WHERE plan_id = {serviceid};";
        //    decimal oldprice = (decimal)dbMan.ExecuteScalar(query);
        //    return oldprice;
        //}
        public DataTable getloyalty()
        {
            string query = $"SELECT L.customer_id, C.name, P.program_name, L.points_redeemed, L.reward FROM Loyalty_Redemptions L, Customers C ,Loyalty_Programs P WHERE C.customer_id=L.customer_id AND P.loyalty_id=L.loyalty_id;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable gettowerloc()
        {
            string query = $"SELECT location,tower_id FROM Towers;";
            return dbMan.ExecuteReader(query);
        }
        public float updateprice(int serviceid, float newprice)
        {
            string query = $"UPDATE Service_Plans SET price={newprice} WHERE plan_id={serviceid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InstallTower(string location, float radius, string status, DateTime maint, float usage)
        {
            string query = $"INSERT INTO Towers(location, coverage_radius, status, last_maintenance_date, energy_usage) VALUES ('{location}', {radius},'{status}', '{maint}', {usage});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemoveTower(int id)
        {
            string query = $"DELETE FROM Towers WHERE tower_id={id};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Launchservice(string name, float price, string limit, int min, string features)
        {
            string query = $"INSERT INTO Service_Plans  (plan_name, price, data_limit, call_minutes, additional_features)VALUES('{name}', {price}, '{limit}', {min}, '{features}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public decimal getusage(int tid)
        {
            string query = $"SELECT energy_usage FROM Towers WHERE tower_id= {tid};";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public DataTable getpayments()
        {
            string query = $"SELECT P.customer_id, C.name, P.amount, P.payment_date, P.payment_method, P.status FROM Payments P, Customers C WHERE C.customer_id=P.customer_id ORDER BY P.amount DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getsalaries()
        {
            string query = $"SELECT name, role, department, salary, assigned_location FROM Employees ORDER BY salary DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getstat()
        {
            string query = $"SELECT SUM(minutes_used) AS total_used_minutes, SUM(sms_sent) AS total_sent_sms, SUM(data_used) AS total_used_data, AVG(rating) AS average_rating_out_of_5, SUM(amount) AS Revenue FROM Service_Usage, Feedback, Payments WHERE status = 'Completed'";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
