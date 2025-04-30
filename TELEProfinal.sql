IF DB_ID('TelecomDBProFinal') IS NULL
    CREATE DATABASE TelecomDBProFinal;
	go
USE TelecomDBProFinal;
GO

-- Service Plans Table (If it doesn't exist)
IF OBJECT_ID('Service_Plans') IS NULL
BEGIN
    CREATE TABLE Service_Plans (
        plan_id INT IDENTITY(1,1) PRIMARY KEY,
        plan_name NVARCHAR(50) NOT NULL,
        price DECIMAL(10, 2),
        data_limit NVARCHAR(50),
        call_minutes INT,
        additional_features NVARCHAR(255)
    );
END;
GO

-- Customers Table
CREATE TABLE Customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    address NVARCHAR(255),
    phone_number NVARCHAR(12) NOT NULL UNIQUE,
    email NVARCHAR(100) UNIQUE,
    loyalty_points INT DEFAULT 0,
    service_plan_id INT,
    FOREIGN KEY (service_plan_id) REFERENCES Service_Plans(plan_id)
        ON DELETE SET NULL 
        ON UPDATE CASCADE 
);
GO


-- Login Table
CREATE TABLE Login (
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
GO

-- Customer_Subscriptions Table
CREATE TABLE Customer_Subscriptions (
    subscription_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    plan_id INT,
    subscription_date DATE NOT NULL,
    status NVARCHAR(50),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY (plan_id) REFERENCES Service_Plans(plan_id)
    ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Employees Table
CREATE TABLE Employees (
    employee_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100),
    role NVARCHAR(50),
    department NVARCHAR(50),
    salary DECIMAL(10, 2),
    assigned_location NVARCHAR(100)
);
GO

-- CEO Table
CREATE TABLE CEO (
    ceo_id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100),
    office_location NVARCHAR(100),
    contact_info NVARCHAR(100)
);
GO

-- Towers Table
CREATE TABLE Towers (
    tower_id INT IDENTITY(1,1) PRIMARY KEY,
    location NVARCHAR(100),
    coverage_radius DECIMAL(5, 2),
    status NVARCHAR(50),
    last_maintenance_date DATE,
    energy_usage DECIMAL(10, 2)
);
GO

-- Tower_Assignments Table
CREATE TABLE Tower_Assignments (
    assignment_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT,
    tower_id INT,
    assignment_date DATE NOT NULL,
    task_description NVARCHAR(MAX),
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (tower_id) REFERENCES Towers(tower_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Network_Issues Table
CREATE TABLE Network_Issues (
    issue_id INT IDENTITY(1,1) PRIMARY KEY,
    tower_id INT,
    issue_type NVARCHAR(100),
    reported_date DATE,
    resolved_date DATE,
    resolution_summary NVARCHAR(MAX),
    FOREIGN KEY (tower_id) REFERENCES Towers(tower_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Service_Usage Table
CREATE TABLE Service_Usage (
    usage_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    plan_id INT,
    data_used DECIMAL(10, 2),
    minutes_used INT,
    sms_sent INT,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY (plan_id) REFERENCES Service_Plans(plan_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Payments Table
CREATE TABLE Payments (
    payment_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    amount DECIMAL(10, 2),
    payment_date DATE,
    payment_method NVARCHAR(50),
    status NVARCHAR(50),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
    ON UPDATE CASCADE
);
GO

-- Purchase Orders Table
CREATE TABLE Purchase_Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    inventory_id INT,
    quantity INT,
    order_status NVARCHAR(50),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE SET NULL ON UPDATE CASCADE
);
GO

-- Inventory Table
CREATE TABLE Inventory (
    inventory_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name NVARCHAR(100),
    quantity INT,
    location NVARCHAR(100),
    status NVARCHAR(50),
    price DECIMAL(10, 2) NOT NULL DEFAULT 0,
);
GO

-- Loyalty_Programs Table
CREATE TABLE Loyalty_Programs (
    loyalty_id INT IDENTITY(1,1) PRIMARY KEY,
    program_name NVARCHAR(100),
    point_conversion_rate DECIMAL(10, 2),
    reward_tiers NVARCHAR(MAX)
);
GO

-- Loyalty_Redemptions Table
CREATE TABLE Loyalty_Redemptions (
    redemption_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    loyalty_id INT,
    points_redeemed INT,
    reward NVARCHAR(100),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (loyalty_id) REFERENCES Loyalty_Programs(loyalty_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Feedback Table
CREATE TABLE Feedback (
    feedback_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    service_feedback NVARCHAR(MAX),
    rating INT,
    feedback_date DATE,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Complaint Table
CREATE TABLE Complaint (
    complaint_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    complaint_date DATE,
    complaint_type NVARCHAR(100),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Regions Table
CREATE TABLE Regions (
    region_id INT IDENTITY(1,1) PRIMARY KEY,
    region_name NVARCHAR(100),
    coverage_area DECIMAL(10, 2),
    population_density DECIMAL(10, 2)
);
GO

-- Create the Customer_Actions table
CREATE TABLE Customer_Actions (
    action_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    action_type NVARCHAR(50), -- 'Call' or 'SMS'
    recipient_number NVARCHAR(15),
    action_timestamp DATETIME DEFAULT GETDATE(),
    duration_seconds INT NULL, -- For calls only
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
    ON UPDATE CASCADE
);
GO
----------------------the insert
USE TelecomDBProFinal;
GO
INSERT INTO CEO(name,office_location,contact_info) VALUES
('CEO','CUFE',011234567);
GO
GO
INSERT INTO Service_Plans (plan_name, price, data_limit, call_minutes, additional_features)
VALUES
('Basic', 20.00, '5GB', 500, 'N/A'),
('Premium', 40.00, '15GB', 1000, 'Free international calls'),
('Unlimited', 60.00, 'Unlimited', 1000000000, 'Free WhatsApp all month');
GO

-- Insert into Customers table
INSERT INTO Customers(name,address,phone_number,email,loyalty_points,service_plan_id) VALUES
('Sara Hassan', '245 Zamalek Ave', '01087654321', 'sara.hassan@yahoo.com', 250, 3),
('Mohamed Fathi', '78 Mohandeseen St', '01055566778', 'mohamedfathi@outlook.com', 300, 1),
('Laila Ibrahim', '56 Nasr City Rd', '01098765432', 'laila.ibrahim@gmail.com', 180, 2),
('Omar Khaled', '98 Heliopolis St', '01034567891', 'omar.khaled@ymail.com', 220, 3),
('Huda Ramadan', '36 Dokki St', '01056781234', 'huda.ramadan@hotmail.com', 160, 1),
('Rami Ahmed', '102 Maadi Rd', '01032456789', 'rami_ahmed@yahoo.com', 280, 2),
('Yara El-Gohary', '24 Garden City St', '01067893212', 'yara.elgohary@gmail.com', 320, 3),
('Tariq Sami', '66 Shubra St', '01045678923', 'tariq.sami@outlook.com', 200, 2),
('Amira Nabil', '44 Agouza St', '01076543210', 'amira.nabil@yahoo.com', 150, 1),
('Khaled Youssef', '31 Mohandeseen St', '01065432109', 'khaled.youssef@hotmail.com', 270, 1),
('Mona Shaker', '19 Zamalek Ave', '01085264137', 'mona.shaker@gmail.com', 230, 3),
('Farida Magdy', '12 Maadi St', '01012398765', 'farida.magdy@yahoo.com', 190, 2),
('Hassan Zaki', '88 Heliopolis St', '01045612345', 'hassan.zaki@outlook.com', 310, 2),
('Nabil Farouk', '53 Nasr City Rd', '01098712345', 'nabil.farouk@gmail.com', 220, 3);
GO
INSERT INTO Towers(location, coverage_radius ,status , last_maintenance_date, energy_usage) VALUES
('Zamalek', 5.5, 'Active', '2024-06-01', 120.5),
('6th October', 8.0, 'Active', '2024-07-01', 150.0),
('Nasr City', 6.5, 'Under Maintenance', '2024-08-01', 200.0),
('Aswan', 10.0, 'Active', '2024-09-01', 175.5),
('Hurghada', 12.0, 'Inactive', '2024-10-01', 250.0),
('City Center', 14.00, 'Active', '2024-07-10', 650.00),
('Down Town', 6.00, 'Maintenance', '2024-03-15', 250.00),
('Maadi', 13.00, 'Active', '2024-10-08', 600.00),
('Mohandseen', 7.50, 'Maintenance', '2024-08-01', 375.00),
('Alex', 9.50, 'Active', '2024-09-17', 480.00),
('Gothem city', 12.50, 'Maintenance', '2024-02-10', 420.00),
('Leyndell', 8.20, 'Active', '2024-11-05', 525.00),
('Tilted Towers', 10.00, 'Maintenance', '2024-07-23', 460.00),
('Rook Islands', 11.50, 'Active', '2024-05-05', 580.00),
('Stardew Valley', 6.50, 'Maintenance', '2024-06-13', 320.00),
('Rapture', 9.80, 'Active', '2024-09-30', 510.00);
GO
INSERT INTO Employees (name, role, department, salary, assigned_location) VALUES
('Mona Ali', 'Sales Executive', 'Sales', 35000.00, 'Region 3'),
('Hassan Zaki', 'Accountant', 'Finance', 45000.00, 'Region 5'),
('Farida Shaker', 'HR Specialist', 'Human Resources', 38000.00, 'Region 1'),
('Tariq Khaled', 'Marketing Manager', 'Marketing', 55000.00, 'Region 2'),
('Sara Ibrahim', 'Customer Support', 'Customer Service', 32000.00, 'Region 4'),
('Rami Gamil', 'Business Analyst', 'Operations', 42000.00, 'Region 6'),
('Amira Samir', 'Data Scientist', 'IT', 60000.00, 'Region 3'),
('Mohamed Essam', 'Project Manager', 'Operations', 48000.00, 'Region 1'),
('Yara Hassan', 'Content Strategist', 'Marketing', 43000.00, 'Region 2'),
('Khaled Nabil', 'Network Engineer', 'Network Operations', 47000.00, 'Tower 4'),
('Mariam Ali', 'PR Coordinator', 'Public Relations', 38000.00, 'Region 5'),
('Ahmed Fawzy', 'Software Developer', 'IT', 51000.00, 'Region 6'),
('Laila Tarek', 'Operations Lead', 'Operations', 55000.00, 'Region 3'),
('Rasha Salah', 'Customer Service Rep', 'Customer Service', 30000.00, 'Region 2'),
('Omar Zayed', 'Legal Advisor', 'Legal', 60000.00, 'Region 4'),
('Huda Ramadan', 'Team Leader', 'Human Resources', 42000.00, 'Region 1'),
('Ahmed Mostafa', 'Technician', 'Network Operations', 40000.00, 'Tower 12');
GO
INSERT INTO Inventory(item_name,quantity,location,status,price) VALUES
('Laptop Dell', 50, 'Warehouse C', 'Available', 1500.00),
('Smartwatch Samsung', 200, 'Warehouse B', 'Available', 250.00),
('Bluetooth Headphones', 300, 'Warehouse D', 'Available', 120.00),
('Tablet iPad', 100, 'Warehouse A', 'Out of Stock', 650.00),
('Sim card', 25, 'Warehouse E', 'Available', 350.00),
('External Hard Drive', 150, 'Warehouse C', 'Available', 75.00),
('Smartphone Samsung', 500, 'Warehouse B', 'Available', 800.00),
('USB Flash Drive', 1000, 'Warehouse A', 'Available', 15.00),
('Keyboard Logitech', 200, 'Warehouse D', 'Available', 45.00),
('Gaming Mouse', 150, 'Warehouse E', 'Available', 30.00),
('Laptop MacBook', 30, 'Warehouse B', 'Out of Stock', 2000.00),
('Portable Charger', 600, 'Warehouse A', 'Available', 25.00),
('Camera Canon', 80, 'Warehouse C', 'Available', 900.00);
GO
INSERT INTO Network_Issues(tower_id,issue_type,reported_date,resolved_date,resolution_summary) VALUES
(4, 'Cable damage', '2024-09-20', '2024-09-21', 'Cables replaced'),
(5, 'Software glitch', '2024-09-25', '2024-09-26', 'System update applied'),
(6, 'Hardware failure', '2024-09-30','2024-10-01', 'Faulty components replaced'),
(7, 'Signal interference', '2024-10-05', '2024-10-06', 'Antenna adjusted'),
(8, 'Network congestion', '2024-10-10', '2024-10-11', 'Bandwidth optimization'),
(9, 'Power surge', '2024-10-15', '2024-10-16', 'Surge protector installed'),
(10, 'System downtime', '2024-10-20', '2024-10-21', 'Rebooted servers'),
(11, 'Signal disruption',NULL,NULL,NULL),
(12, 'Network failure',NULL,NULL,NULL),
(13, 'Hardware malfunction',NULL,NULL,NULL),
(14, 'Software crash',NULL,NULL,NULL),
(15, 'Overheating issue',NULL,NULL,NULL),
(16, 'Power loss',NULL,NULL,NULL),
(1, 'Connectivity issue',NULL,NULL,NULL),
(2, 'Server crash',NULL,NULL,NULL),
(3, 'Data corruption',NULL,NULL,NULL);
GO
INSERT INTO Feedback(customer_id,service_feedback,rating,feedback_date) VALUES
(4, 'Fast and efficient', 5, '2024-08-25'),
(5, 'Poor signal quality', 2, '2024-08-18'),
(6, 'Customer service is helpful', 4, '2024-08-22'),
(7, 'Very satisfied with the service', 5, '2024-08-14'),
(8, 'Unstable connection', 3, '2024-08-17'),
(9, 'Friendly staff, quick support', 4, '2024-08-19'),
(10, 'Frequent service interruptions', 2, '2024-08-23'),
(11, 'Smooth experience, no issues', 5, '2024-08-12'),
(12, 'Slow internet speed', 3, '2024-08-16'),
(13, 'Helpful troubleshooting', 4, '2024-08-21'),
(14, 'Great coverage and speed', 5, '2024-08-13'),
(1, 'Not responsive enough', 2, '2024-08-11'),
(2, 'Reliable network service', 5, '2024-08-24'),
(3, 'Poor customer support', 1, '2024-08-09');
GO
INSERT INTO Payments(customer_id,amount,payment_date,payment_method,status) VALUES
(4, 15.00, '2024-08-25', 'Credit Card', 'Completed'),
(5, 30.00, '2024-08-22', 'Bank Transfer', 'Pending'),
(6, 50.00, '2024-08-18', 'Fawry', 'Completed'),
(7, 25.00, '2024-08-23', 'Credit Card', 'Completed'),
(8, 45.00, '2024-08-21', 'Bank Transfer', 'Pending'),
(9, 60.00, '2024-08-19', 'Fawry', 'Completed'),
(10, 35.00, '2024-08-17', 'Credit Card', 'Completed'),
(11, 55.00, '2024-08-16', 'Bank Transfer', 'Completed'),
(12, 40.00, '2024-08-14', 'Fawry', 'Pending'),
(13, 30.00, '2024-08-13', 'Credit Card', 'Completed'),
(14, 70.00, '2024-08-12', 'Bank Transfer', 'Completed'),
(1, 20.00, '2024-08-11', 'Fawry', 'Pending'),
(2, 60.00, '2024-08-10', 'Credit Card', 'Completed'),
(3, 50.00, '2024-08-09', 'Bank Transfer', 'Pending');
GO
INSERT INTO Purchase_Orders(customer_id,inventory_id,quantity,order_status) VALUES
(2, 2, 5,'pending'),
(3,3,1,'delivered'),
(4, 4, 2, 'pending'),
(5, 5, 4, 'delivered'),
(6, 6, 3, 'delivered'),
(7, 7, 6, 'pending'),
(8, 8, 2, 'delivered'),
(9, 9, 5, 'pending'),
(10, 10, 1, 'delivered'),
(11, 11, 4, 'pending'),
(12, 12, 3, 'delivered'),
(13, 13, 6, 'pending'),
(14, 14, 2, 'delivered'),
(1, 15, 5, 'pending');
GO
INSERT INTO Login (customer_id, username, password_hash)
VALUES
(1, 'ahmed123', 'MWAH'),
(2, 'sara987', '123'),
(3, 'mohamed321', '321'),
(4, 'huda456', 'a'),
(5, 'youssef789', 'yoyo12'),
(6, 'lana_cool', 'lanapass'),
(7, 'karim456', 'kpass123'),
(8, 'salma_qwerty', 'qwerty321'),
(9, 'mariam_ahmed', 'm4hmed'),
(10, 'tarek_zaki', 'tzki2024'),
(11, 'fatma_star', 'ftmstars'),
(12, 'omar_90', 'omrpass'),
(13, 'ramy_boss', 'rmy2024'),
(14, 'noha_egy', 'noha678');
GO
INSERT INTO Customer_Subscriptions (customer_id, plan_id, subscription_date, status)
VALUES
(1, 1, '2024-01-01', 'Active'),
(2, 2, '2024-02-01', 'Active'),
(3, 3, '2024-03-01', 'Inactive'),
(4, 1, '2024-04-01', 'Active'),
(5, 2, '2024-05-01', 'Pending'),
(6, 2, '2024-06-01', 'Active'),
(7, 3, '2024-07-01', 'Pending'),
(8, 3, '2024-08-01', 'Inactive'),
(9, 1, '2024-09-01', 'Active'),
(10, 2, '2024-10-01', 'Active'),
(11, 3, '2024-11-01', 'Inactive'),
(12, 1, '2024-12-01', 'Active'),
(13, 1, '2025-01-01', 'Active'),
(14, 2, '2025-02-01', 'Pending');
GO
INSERT INTO Tower_Assignments (employee_id, tower_id, assignment_date, task_description)
VALUES
(1, 1, '2024-06-10', 'Routine Maintenance'),
(2, 2, '2024-07-15', 'New Installation'),
(3, 3, '2024-08-20', 'Network Optimization'),
(4, 4, '2024-09-25', 'Emergency Repair'),
(5, 5, '2024-10-30', 'Power Upgrade'),
(6, 1, '2024-11-05', 'Inspect Hardware'),
(7, 2, '2024-12-10', 'Tower Base Stabilization'),
(8, 3, '2024-12-15', 'Reconfigure Antennas'),
(9, 4, '2025-01-10', 'Renew Software License'),
(10, 5, '2025-02-01', 'Install Additional Panels'),
(3, 2, '2025-03-05', 'Energy Optimization'),
(4, 1, '2025-03-10', 'Routine Maintenance'),
(2, 4, '2025-03-15', 'Upgrade Firmware'),
(5, 3, '2025-03-20', 'Check Connectivity'),
(1, 5, '2025-03-25', 'Install New Backup Power');
GO
INSERT INTO Service_Usage (customer_id, plan_id, data_used, minutes_used, sms_sent)
VALUES
(1, 1, 2.5, 250, 100),
(2, 2, 8.0, 900, 200),
(3, 3, 15.5, 1900, 300),
(4, 1, 45.0, 2900, 400),
(5, 2, 100.0, 4500, 500),
(6, 2, 3.2, 310, 110),
(7, 3, 7.8, 560, 220),
(8, 1, 18.5, 1500, 310),
(9, 1, 25.0, 1800, 400),
(10, 2, 55.5, 3500, 510),
(11, 3, 6.8, 870, 150),
(12, 3, 38.0, 2100, 430),
(13, 1, 2.3, 120, 50),
(14, 2, 9.0, 400, 90);
GO
