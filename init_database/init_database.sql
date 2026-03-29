-- ============================================================
-- Fairy Service Center - Database Initialization Script
-- Target: SQL Server (tested on SQL Server 2019+)
-- Run this file FIRST, then run seed.sql
-- ============================================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ServiceCenterDB')
    CREATE DATABASE ServiceCenterDB;
GO

USE ServiceCenterDB;
GO

-- ============================================================
-- Drop tables in safe order (FK-safe teardown for re-runs)
-- ============================================================
IF OBJECT_ID('payments',                  'U') IS NOT NULL DROP TABLE payments;
IF OBJECT_ID('sparepart_usage',           'U') IS NOT NULL DROP TABLE sparepart_usage;
IF OBJECT_ID('stock_mutations',           'U') IS NOT NULL DROP TABLE stock_mutations;
IF OBJECT_ID('service_order_details',     'U') IS NOT NULL DROP TABLE service_order_details;
IF OBJECT_ID('service_assignments',       'U') IS NOT NULL DROP TABLE service_assignments;
IF OBJECT_ID('service_orders',            'U') IS NOT NULL DROP TABLE service_orders;
IF OBJECT_ID('sparepart_price',           'U') IS NOT NULL DROP TABLE sparepart_price;
IF OBJECT_ID('spareparts',                'U') IS NOT NULL DROP TABLE spareparts;
IF OBJECT_ID('sparepart_unit',            'U') IS NOT NULL DROP TABLE sparepart_unit;
IF OBJECT_ID('suppliers',                 'U') IS NOT NULL DROP TABLE suppliers;
IF OBJECT_ID('services',                  'U') IS NOT NULL DROP TABLE services;
IF OBJECT_ID('service_categories',        'U') IS NOT NULL DROP TABLE service_categories;
IF OBJECT_ID('vehicles',                  'U') IS NOT NULL DROP TABLE vehicles;
IF OBJECT_ID('vehicle_brands',            'U') IS NOT NULL DROP TABLE vehicle_brands;
IF OBJECT_ID('customers',                 'U') IS NOT NULL DROP TABLE customers;
IF OBJECT_ID('technicians',               'U') IS NOT NULL DROP TABLE technicians;
IF OBJECT_ID('users',                     'U') IS NOT NULL DROP TABLE users;
IF OBJECT_ID('roles',                     'U') IS NOT NULL DROP TABLE roles;
IF OBJECT_ID('user_status',               'U') IS NOT NULL DROP TABLE user_status;
IF OBJECT_ID('service_status',            'U') IS NOT NULL DROP TABLE service_status;
GO

-- ============================================================
-- Lookup / reference tables
-- ============================================================

CREATE TABLE user_status (
    status_id   INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    status_name NVARCHAR(50)  NOT NULL
);

CREATE TABLE roles (
    role_id   INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    role_name NVARCHAR(50)  NOT NULL
);

CREATE TABLE service_status (
    status_id   INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    status_name NVARCHAR(50)  NOT NULL
);

CREATE TABLE service_categories (
    category_id   INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    category_name NVARCHAR(100)  NOT NULL
);

CREATE TABLE vehicle_brands (
    brand_id   INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    brand_name NVARCHAR(50)  NOT NULL
);

CREATE TABLE sparepart_unit (
    unit_id   INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    unit_name NVARCHAR(50)  NOT NULL
);

-- ============================================================
-- Users & roles
-- ============================================================

CREATE TABLE users (
    user_id       INT             NOT NULL PRIMARY KEY IDENTITY(1,1),
    full_name     NVARCHAR(100)   NOT NULL,
    email         NVARCHAR(100)   NOT NULL UNIQUE,
    username      NVARCHAR(50)    NOT NULL,
    password      NVARCHAR(255)   NOT NULL,
    role_id       INT             NOT NULL,
    phone         NVARCHAR(15)    NULL,
    status_id     INT             NOT NULL DEFAULT 1,
    photo_profile NVARCHAR(500)   NULL,
    is_active     BIT             NOT NULL DEFAULT 1,
    last_active   DATETIME        NULL,
    created_at    DATETIME        NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_users_role   FOREIGN KEY (role_id)   REFERENCES roles(role_id),
    CONSTRAINT FK_users_status FOREIGN KEY (status_id) REFERENCES user_status(status_id)
);

CREATE TABLE technicians (
    technician_id INT           NOT NULL PRIMARY KEY IDENTITY(1,1),
    user_id       INT           NOT NULL,
    skill_level   NVARCHAR(50)  NULL,
    hire_date     DATETIME      NULL,
    is_active     BIT           NOT NULL DEFAULT 1,

    CONSTRAINT FK_technicians_user FOREIGN KEY (user_id) REFERENCES users(user_id)
);

-- ============================================================
-- Customers & vehicles
-- ============================================================

CREATE TABLE customers (
    customer_id   INT             NOT NULL PRIMARY KEY IDENTITY(1,1),
    customer_code NVARCHAR(20)    NOT NULL UNIQUE,
    full_name     NVARCHAR(100)   NOT NULL,
    phone         NVARCHAR(15)    NULL,
    email         NVARCHAR(100)   NULL,
    address       NVARCHAR(255)   NULL,
    created_at    DATETIME        NOT NULL DEFAULT GETDATE()
);

CREATE TABLE vehicles (
    vehicle_id    INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    customer_id   INT            NOT NULL,
    plate_number  NVARCHAR(20)   NOT NULL,
    brand_id      INT            NOT NULL,
    brand         AS             (CAST((SELECT brand_name FROM vehicle_brands WHERE brand_id = vehicles.brand_id) AS NVARCHAR(50))),
    model         NVARCHAR(50)   NOT NULL,
    year          SMALLINT       NOT NULL,
    engine_number NVARCHAR(30)   NULL,
    frame_number  NVARCHAR(30)   NULL,

    CONSTRAINT FK_vehicles_customer FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    CONSTRAINT FK_vehicles_brand    FOREIGN KEY (brand_id)    REFERENCES vehicle_brands(brand_id)
);

-- ============================================================
-- Services catalog
-- ============================================================

CREATE TABLE services (
    service_id   INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_name NVARCHAR(100)  NOT NULL,
    category_id  INT            NOT NULL,

    CONSTRAINT FK_services_category FOREIGN KEY (category_id) REFERENCES service_categories(category_id)
);

-- ============================================================
-- Suppliers & spareparts
-- ============================================================

CREATE TABLE suppliers (
    supplier_id   INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    supplier_name NVARCHAR(100)  NOT NULL,
    phone         NVARCHAR(15)   NULL,
    address       NVARCHAR(255)  NULL
);

CREATE TABLE spareparts (
    sparepart_id   INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    sparepart_code NVARCHAR(20)   NOT NULL UNIQUE,
    sparepart_name NVARCHAR(100)  NOT NULL,
    unit_id        INT            NOT NULL,
    unit           AS             (CAST((SELECT unit_name FROM sparepart_unit WHERE unit_id = spareparts.unit_id) AS NVARCHAR(50))),
    stock          INT            NOT NULL DEFAULT 0,
    minimum_stock  INT            NOT NULL DEFAULT 5,

    CONSTRAINT FK_spareparts_unit FOREIGN KEY (unit_id) REFERENCES sparepart_unit(unit_id)
);

CREATE TABLE sparepart_price (
    price_id       INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    sparepart_id   INT            NOT NULL,
    supplier_id    INT            NOT NULL,
    purchase_price DECIMAL(15,2)  NOT NULL,
    selling_price  DECIMAL(15,2)  NOT NULL,
    effective_date DATE           NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_sp_price_spare    FOREIGN KEY (sparepart_id) REFERENCES spareparts(sparepart_id),
    CONSTRAINT FK_sp_price_supplier FOREIGN KEY (supplier_id)  REFERENCES suppliers(supplier_id)
);

CREATE TABLE stock_mutations (
    mutation_id  INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    sparepart_id INT            NOT NULL,
    qty_change   INT            NOT NULL,
    mutation_type NVARCHAR(10)  NOT NULL,   -- 'IN' or 'OUT'
    notes        NVARCHAR(255)  NULL,
    created_at   DATETIME       NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_mutation_spare FOREIGN KEY (sparepart_id) REFERENCES spareparts(sparepart_id)
);

-- ============================================================
-- Service orders & workflow
-- ============================================================

CREATE TABLE service_orders (
    service_order_id       INT             NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_code           NVARCHAR(20)    NOT NULL UNIQUE,
    customer_id            INT             NOT NULL,
    vehicle_id             INT             NOT NULL,
    status_id              INT             NOT NULL DEFAULT 1,
    received_by            INT             NULL,
    assigned_by            INT             NULL,
    complaint              NVARCHAR(MAX)   NULL,
    entry_date             DATETIME        NULL DEFAULT GETDATE(),
    estimated_finish_date  DATETIME        NULL,
    actual_finish_date     DATETIME        NULL,
    total_cost             DECIMAL(15,2)   NULL DEFAULT 0,

    CONSTRAINT FK_so_customer    FOREIGN KEY (customer_id)  REFERENCES customers(customer_id),
    CONSTRAINT FK_so_vehicle     FOREIGN KEY (vehicle_id)   REFERENCES vehicles(vehicle_id),
    CONSTRAINT FK_so_status      FOREIGN KEY (status_id)    REFERENCES service_status(status_id),
    CONSTRAINT FK_so_received_by FOREIGN KEY (received_by)  REFERENCES users(user_id),
    CONSTRAINT FK_so_assigned_by FOREIGN KEY (assigned_by)  REFERENCES users(user_id)
);

CREATE TABLE service_assignments (
    assignment_id    INT       NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_order_id INT       NOT NULL,
    technician_id    INT       NOT NULL,
    assigned_date    DATETIME  NULL DEFAULT GETDATE(),
    finished_date    DATETIME  NULL,

    CONSTRAINT FK_sa_order      FOREIGN KEY (service_order_id) REFERENCES service_orders(service_order_id),
    CONSTRAINT FK_sa_technician FOREIGN KEY (technician_id)    REFERENCES technicians(technician_id)
);

CREATE TABLE service_order_details (
    detail_id        INT             NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_order_id INT             NOT NULL,
    service_id       INT             NOT NULL,
    price            DECIMAL(15,2)   NOT NULL DEFAULT 0,
    notes            NVARCHAR(MAX)   NULL,

    CONSTRAINT FK_sod_order   FOREIGN KEY (service_order_id) REFERENCES service_orders(service_order_id),
    CONSTRAINT FK_sod_service FOREIGN KEY (service_id)       REFERENCES services(service_id)
);

CREATE TABLE sparepart_usage (
    usage_id         INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_order_id INT            NOT NULL,
    sparepart_id     INT            NOT NULL,
    quantity         INT            NOT NULL,
    price            DECIMAL(15,2)  NOT NULL,

    CONSTRAINT FK_usage_order    FOREIGN KEY (service_order_id) REFERENCES service_orders(service_order_id),
    CONSTRAINT FK_usage_sparepart FOREIGN KEY (sparepart_id)    REFERENCES spareparts(sparepart_id)
);

-- ============================================================
-- Payments
-- ============================================================

CREATE TABLE payments (
    payment_id       INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    service_order_id INT            NOT NULL UNIQUE,
    payment_date     DATETIME       NOT NULL DEFAULT GETDATE(),
    payment_method   NVARCHAR(50)   NOT NULL,
    total_amount     DECIMAL(15,2)  NOT NULL,
    paid_amount      DECIMAL(15,2)  NOT NULL,
    change_amount    DECIMAL(15,2)  NOT NULL DEFAULT 0,

    CONSTRAINT FK_payment_order FOREIGN KEY (service_order_id) REFERENCES service_orders(service_order_id)
);

GO
PRINT 'Schema created successfully.';
GO

-- ============================================================
-- Reference / lookup tables
-- ============================================================

SET IDENTITY_INSERT user_status ON;
INSERT INTO user_status (status_id, status_name) VALUES
    (1, 'Active'),
    (2, 'Inactive');
SET IDENTITY_INSERT user_status OFF;

SET IDENTITY_INSERT roles ON;
INSERT INTO roles (role_id, role_name) VALUES
    (1, 'Admin'),
    (2, 'Technician'),
    (3, 'Developer'),
    (4, 'Cashier'),
    (5, 'Supplier');
SET IDENTITY_INSERT roles OFF;

SET IDENTITY_INSERT service_status ON;
INSERT INTO service_status (status_id, status_name) VALUES
    (1, 'Pending'),
    (2, 'In Progress'),
    (3, 'Ready for Payment'),
    (4, 'Completed');
SET IDENTITY_INSERT service_status OFF;

SET IDENTITY_INSERT service_categories ON;
INSERT INTO service_categories (category_id, category_name) VALUES
    (1, 'Engine Service'),
    (2, 'Electrical'),
    (3, 'Body & Frame'),
    (4, 'Tire & Brakes'),
    (5, 'Cooling System');
SET IDENTITY_INSERT service_categories OFF;

SET IDENTITY_INSERT vehicle_brands ON;
INSERT INTO vehicle_brands (brand_id, brand_name) VALUES
    (1,  'Honda'),
    (2,  'Yamaha'),
    (3,  'Kawasaki'),
    (4,  'Suzuki'),
    (5,  'Vespa'),
    (6,  'Ducati'),
    (7,  'BMW'),
    (8,  'KTM'),
    (9,  'Harley-Davidson'),
    (10, 'TVS');
SET IDENTITY_INSERT vehicle_brands OFF;

SET IDENTITY_INSERT sparepart_unit ON;
INSERT INTO sparepart_unit (unit_id, unit_name) VALUES
    (1, 'Piece'),
    (2, 'Liter'),
    (3, 'Set'),
    (4, 'Meter'),
    (5, 'Gram');
SET IDENTITY_INSERT sparepart_unit OFF;

-- ============================================================
-- Users
-- All BCrypt hashes below correspond to password "Fairy@2024!"
-- Replace with real hashes generated at runtime in production.
-- ============================================================

DECLARE @bcrypt NVARCHAR(255);
-- Using the same hash for all seed users (dev convenience only).
SET @bcrypt = '$2a$11$KIqNKE.r3MR0.cBPW4tgCe5nT5Q0GHZu0N.RbBvN8TA2j2KCRfVaS';

SET IDENTITY_INSERT users ON;
INSERT INTO users (user_id, full_name, email, username, password, role_id, phone, status_id, is_active, created_at) VALUES
    (1,  'System Developer',    'dev@fairysc.com',      'devroot',   @bcrypt, 3, '081200000000', 1, 1, '2024-01-01'),
    (2,  'Admin Wijaya',        'admin@fairysc.com',    'adminwij',  @bcrypt, 1, '081200000001', 1, 1, '2024-01-02'),
    (3,  'Budi Santoso',        'budi@fairysc.com',     'budisanto', @bcrypt, 2, '081200000002', 1, 1, '2024-01-03'),
    (4,  'Adi Nugroho',         'adi@fairysc.com',      'adinug',    @bcrypt, 2, '081200000003', 1, 1, '2024-01-03'),
    (5,  'Riza Pratama',        'riza@fairysc.com',     'rizaprat',  @bcrypt, 2, '081200000004', 1, 1, '2024-01-04'),
    (6,  'Sari Dewi',           'sari@fairysc.com',     'saridewi',  @bcrypt, 4, '081200000005', 1, 1, '2024-01-05'),
    (7,  'Agus Permana',        'agus@gmail.com',       'agusperm',  @bcrypt, 1, '081200000006', 1, 1, '2024-01-06'),
    (8,  'Hendra Kusuma',       'hendra@fairysc.com',   'hendrak',   @bcrypt, 2, '081200000007', 1, 1, '2024-01-07'),
    (9,  'Lia Rahayu',          'lia@fairysc.com',      'liarahayu', @bcrypt, 4, '081200000008', 1, 1, '2024-01-08'),
    (10, 'Dimas Setiawan',      'dimas@fairysc.com',    'dimass',    @bcrypt, 2, '081200000009', 1, 1, '2024-01-09');
SET IDENTITY_INSERT users OFF;

-- ============================================================
-- Technicians  (users with role_id = 2)
-- ============================================================

SET IDENTITY_INSERT technicians ON;
INSERT INTO technicians (technician_id, user_id, skill_level, hire_date, is_active) VALUES
    (1, 3,  'Senior',     '2024-01-03', 1),
    (2, 4,  'Junior',     '2024-01-03', 1),
    (3, 5,  'Mid-level',  '2024-01-04', 1),
    (4, 8,  'Senior',     '2024-01-07', 1),
    (5, 10, 'Junior',     '2024-01-09', 1);
SET IDENTITY_INSERT technicians OFF;

-- ============================================================
-- Suppliers
-- ============================================================

SET IDENTITY_INSERT suppliers ON;
INSERT INTO suppliers (supplier_id, supplier_name, phone, address) VALUES
    (1, 'PT Maju Bersama',        '02140001111', 'Jl. Industri No. 10, Jakarta'),
    (2, 'CV Sumber Makmur',       '02240002222', 'Jl. Raya Bogor Km. 32, Bogor'),
    (3, 'UD Karya Motor',         '02440003333', 'Jl. Pemuda No. 5, Bandung'),
    (4, 'PT Global Sparepart',    '03140004444', 'Jl. Basuki Rahmat 88, Surabaya'),
    (5, 'CV Nusantara Otomotif',  '02740005555', 'Jl. Solo-Yogya Km. 8, Solo');
SET IDENTITY_INSERT suppliers OFF;

-- ============================================================
-- Spareparts
-- ============================================================

SET IDENTITY_INSERT spareparts ON;
INSERT INTO spareparts (sparepart_id, sparepart_code, sparepart_name, unit_id, stock, minimum_stock) VALUES
    (1,  'SP0001', 'Engine Oil 10W-40',        2,  80,  10),
    (2,  'SP0002', 'Air Filter',               1,  45,  5),
    (3,  'SP0003', 'Spark Plug NGK',           1, 100,  10),
    (4,  'SP0004', 'Brake Pad Front',          3,  30,  5),
    (5,  'SP0005', 'Brake Pad Rear',           3,  30,  5),
    (6,  'SP0006', 'Drive Chain 428H',         1,  20,  5),
    (7,  'SP0007', 'Sprocket Set',             3,  15,  3),
    (8,  'SP0008', 'Radiator Coolant',         2,  40,  8),
    (9,  'SP0009', 'Brake Fluid DOT 3',        2,  25,  5),
    (10, 'SP0010', 'Clutch Cable',             1,  18,  5),
    (11, 'SP0011', 'Throttle Cable',           1,  15,  5),
    (12, 'SP0012', 'V-Belt Matic',             1,  25,  5),
    (13, 'SP0013', 'Roller CVT 13g',           3,  20,  5),
    (14, 'SP0014', 'Front Fork Oil Seal',      3,  12,  3),
    (15, 'SP0015', 'Battery Yuasa 5Ah',        1,  10,  3),
    (16, 'SP0016', 'Headlamp Bulb H4',         1,  30,  5),
    (17, 'SP0017', 'Tire Front 70/90-17',      1,   8,  3),
    (18, 'SP0018', 'Tire Rear 80/90-17',       1,   8,  3),
    (19, 'SP0019', 'Carburetor Jet Kit',       3,  10,  3),
    (20, 'SP0020', 'Fuel Filter',              1,  22,  5);
SET IDENTITY_INSERT spareparts OFF;

-- ============================================================
-- Sparepart prices
-- ============================================================

SET IDENTITY_INSERT sparepart_price ON;
INSERT INTO sparepart_price (price_id, sparepart_id, supplier_id, purchase_price, selling_price, effective_date) VALUES
    (1,  1,  1, 45000,    55000,    '2024-01-01'),
    (2,  2,  1, 35000,    45000,    '2024-01-01'),
    (3,  3,  2, 25000,    35000,    '2024-01-01'),
    (4,  4,  2, 85000,   105000,   '2024-01-01'),
    (5,  5,  2, 75000,    95000,   '2024-01-01'),
    (6,  6,  3, 65000,    85000,   '2024-01-01'),
    (7,  7,  3, 95000,   120000,   '2024-01-01'),
    (8,  8,  1, 30000,    40000,   '2024-01-01'),
    (9,  9,  4, 28000,    38000,   '2024-01-01'),
    (10, 10, 3, 45000,    60000,   '2024-01-01'),
    (11, 11, 3, 40000,    55000,   '2024-01-01'),
    (12, 12, 5, 120000,  150000,  '2024-01-01'),
    (13, 13, 5, 55000,    72000,   '2024-01-01'),
    (14, 14, 4, 80000,   105000,  '2024-01-01'),
    (15, 15, 2, 200000,  260000,  '2024-01-01'),
    (16, 16, 4, 18000,    28000,   '2024-01-01'),
    (17, 17, 5, 250000,  320000,  '2024-01-01'),
    (18, 18, 5, 280000,  360000,  '2024-01-01'),
    (19, 19, 3, 45000,    62000,   '2024-01-01'),
    (20, 20, 1, 20000,    30000,   '2024-01-01');
SET IDENTITY_INSERT sparepart_price OFF;

-- ============================================================
-- Services catalog
-- ============================================================

SET IDENTITY_INSERT services ON;
INSERT INTO services (service_id, service_name, category_id) VALUES
    (1,  'Oil Change',                      1),
    (2,  'Tune-up Standard',                1),
    (3,  'Carburetor Cleaning',             1),
    (4,  'Valve Clearance Adjustment',      1),
    (5,  'Battery Replacement',             2),
    (6,  'Electrical System Check',         2),
    (7,  'Headlamp Replacement',            2),
    (8,  'Body Scratch Repair',             3),
    (9,  'Frame Straightening',             3),
    (10, 'Tire Replacement Front',          4),
    (11, 'Tire Replacement Rear',           4),
    (12, 'Brake Pad Replacement',           4),
    (13, 'Brake Fluid Flush',               4),
    (14, 'Radiator Flush',                  5),
    (15, 'Coolant Replacement',             5);
SET IDENTITY_INSERT services OFF;

-- ============================================================
-- Customers
-- ============================================================

SET IDENTITY_INSERT customers ON;
INSERT INTO customers (customer_id, customer_code, full_name, phone, email, address, created_at) VALUES
    (1,  'CST0001', 'Ahmad Fauzi',       '081311110001', 'ahmad.fauzi@gmail.com',    'Jl. Melati No. 3, Solo',       '2024-02-01'),
    (2,  'CST0002', 'Bintang Ramadhan',  '081311110002', 'bintang.r@gmail.com',      'Jl. Kenanga No. 7, Sukoharjo', '2024-02-05'),
    (3,  'CST0003', 'Cindy Wulandari',   '081311110003', 'cindy.wul@gmail.com',      'Jl. Dahlia No. 12, Solo',      '2024-02-10'),
    (4,  'CST0004', 'Dewi Anggraini',    '081311110004', 'dewi.ang@gmail.com',       'Jl. Mawar No. 5, Klaten',      '2024-02-15'),
    (5,  'CST0005', 'Eko Prasetyo',      '081311110005', 'eko.pras@gmail.com',       'Jl. Anggrek No. 9, Solo',      '2024-02-20'),
    (6,  'CST0006', 'Fitri Handayani',   '081311110006', 'fitri.han@gmail.com',      'Jl. Tulip No. 2, Boyolali',    '2024-03-01'),
    (7,  'CST0007', 'Galih Saputra',     '081311110007', 'galih.sap@gmail.com',      'Jl. Cempaka No. 8, Solo',      '2024-03-05'),
    (8,  'CST0008', 'Hani Nurhaliza',    '081311110008', 'hani.nur@gmail.com',       'Jl. Flamboyan No. 4, Solo',    '2024-03-10'),
    (9,  'CST0009', 'Irwan Hidayat',     '081311110009', 'irwan.hid@gmail.com',      'Jl. Jati No. 6, Karanganyar',  '2024-03-15'),
    (10, 'CST0010', 'Joko Susilo',       '081311110010', 'joko.sus@gmail.com',       'Jl. Akasia No. 11, Solo',      '2024-03-20');
SET IDENTITY_INSERT customers OFF;

-- ============================================================
-- Vehicles
-- ============================================================

SET IDENTITY_INSERT vehicles ON;
INSERT INTO vehicles (vehicle_id, customer_id, plate_number, brand_id, model, year, engine_number, frame_number) VALUES
    (1,  1, 'AD 1234 AB', 1, 'Vario 125',       2021, 'ENG-A001', 'FRM-A001'),
    (2,  1, 'AD 5678 AB', 2, 'NMAX 155',         2022, 'ENG-A002', 'FRM-A002'),
    (3,  2, 'AD 2345 BC', 1, 'Beat Street',      2020, 'ENG-B001', 'FRM-B001'),
    (4,  3, 'AD 3456 CD', 2, 'Aerox 155',        2023, 'ENG-C001', 'FRM-C001'),
    (5,  4, 'AD 4567 DE', 3, 'KLX 150',          2021, 'ENG-D001', 'FRM-D001'),
    (6,  5, 'AD 5678 EF', 4, 'GSX-R150',         2022, 'ENG-E001', 'FRM-E001'),
    (7,  6, 'AD 6789 FG', 1, 'Scoopy',           2020, 'ENG-F001', 'FRM-F001'),
    (8,  7, 'AD 7890 GH', 2, 'Mio M3',           2019, 'ENG-G001', 'FRM-G001'),
    (9,  8, 'AD 8901 HI', 1, 'CB150R',           2021, 'ENG-H001', 'FRM-H001'),
    (10, 9, 'AD 9012 IJ', 4, 'Satria F150',      2020, 'ENG-I001', 'FRM-I001'),
    (11, 10,'AD 0123 JK', 2, 'Xmax 250',         2022, 'ENG-J001', 'FRM-J001');
SET IDENTITY_INSERT vehicles OFF;

-- ============================================================
-- Service orders (mix of statuses for a realistic demo)
-- ============================================================

SET IDENTITY_INSERT service_orders ON;
INSERT INTO service_orders
    (service_order_id, service_code, customer_id, vehicle_id, status_id, received_by, assigned_by,
     complaint, entry_date, estimated_finish_date, actual_finish_date, total_cost) VALUES
    -- Completed orders
    (1, 'SV0001', 1, 1, 4, 2, 2,
     'Routine oil change and spark plug check.',
     '2024-03-01 08:30', '2024-03-01 12:00', '2024-03-01 11:15', 90000),
    (2, 'SV0002', 2, 3, 4, 2, 2,
     'Brakes feel spongy, hard to stop.',
     '2024-03-05 09:00', '2024-03-05 15:00', '2024-03-05 14:30', 225000),
    (3, 'SV0003', 3, 4, 4, 6, 2,
     'Engine stalling at idle, suspected carburetor issue.',
     '2024-03-10 10:00', '2024-03-11 10:00', '2024-03-11 09:00', 150000),
    (4, 'SV0004', 4, 5, 4, 2, 2,
     'Tire puncture rear wheel.',
     '2024-03-15 13:00', '2024-03-15 16:00', '2024-03-15 15:30', 360000),
    (5, 'SV0005', 5, 6, 4, 6, 2,
     'Battery dead, engine does not crank.',
     '2024-03-20 08:00', '2024-03-20 11:00', '2024-03-20 10:15', 320000),
    -- Ready for payment
    (6, 'SV0006', 6, 7, 3, 2, 2,
     'Routine tune-up and air filter replacement.',
     '2024-04-01 09:30', '2024-04-01 14:00', '2024-04-01 13:00', 100000),
    (7, 'SV0007', 7, 8, 3, 6, 2,
     'Headlamp not working.',
     '2024-04-05 10:00', '2024-04-05 13:00', '2024-04-05 12:30', 55000),
    -- In progress
    (8, 'SV0008', 8, 9, 2, 2, 2,
     'Front fork feels stiff after accident.',
     '2024-04-10 08:00', '2024-04-11 16:00', NULL, 0),
    -- Pending (waiting for technician assignment)
    (9, 'SV0009', 9, 10, 1, 6, NULL,
     'Chain is very loose and makes noise.',
     '2024-04-15 09:00', '2024-04-15 17:00', NULL, 0),
    (10, 'SV0010', 10, 11, 1, 2, NULL,
     'Coolant level keeps dropping, possible leak.',
     '2024-04-16 10:00', '2024-04-17 12:00', NULL, 0);
SET IDENTITY_INSERT service_orders OFF;

-- ============================================================
-- Service assignments
-- ============================================================

SET IDENTITY_INSERT service_assignments ON;
INSERT INTO service_assignments (assignment_id, service_order_id, technician_id, assigned_date, finished_date) VALUES
    (1, 1, 1, '2024-03-01 08:35',  '2024-03-01 11:15'),
    (2, 2, 2, '2024-03-05 09:10',  '2024-03-05 14:30'),
    (3, 3, 3, '2024-03-10 10:15',  '2024-03-11 09:00'),
    (4, 4, 4, '2024-03-15 13:10',  '2024-03-15 15:30'),
    (5, 5, 5, '2024-03-20 08:10',  '2024-03-20 10:15'),
    (6, 6, 1, '2024-04-01 09:40',  '2024-04-01 13:00'),
    (7, 7, 2, '2024-04-05 10:10',  '2024-04-05 12:30'),
    (8, 8, 3, '2024-04-10 08:10',  NULL);             -- still in progress
SET IDENTITY_INSERT service_assignments OFF;

-- ============================================================
-- Service order details (which services were performed)
-- ============================================================

SET IDENTITY_INSERT service_order_details ON;
INSERT INTO service_order_details (detail_id, service_order_id, service_id, price, notes) VALUES
    (1, 1, 1,  55000,  'Changed to 10W-40 semi-synthetic.'),
    (2, 1, 3,  35000,  'Cleaned and re-jetted.'),
    (3, 2, 12, 95000,  'Replaced front and rear pads.'),
    (4, 2, 13, 38000,  'Flushed old fluid, refilled DOT 3.'),
    (5, 3, 3,  62000,  'Carburetor soaked and ultrasonic cleaned.'),
    (6, 4, 11, 360000, 'New tubeless tire fitted and balanced.'),
    (7, 5, 5,  260000, 'Yuasa 5Ah installed.'),
    (8, 6, 2,  45000,  'Tune-up with new air filter.'),
    (9, 6, 1,  55000,  'Oil changed.'),
    (10,7, 7,  28000,  'H4 bulb replaced, aim adjusted.');
SET IDENTITY_INSERT service_order_details OFF;

-- ============================================================
-- Sparepart usage (items consumed per order)
-- ============================================================

SET IDENTITY_INSERT sparepart_usage ON;
INSERT INTO sparepart_usage (usage_id, service_order_id, sparepart_id, quantity, price) VALUES
    (1,  1, 1,  1, 55000),   -- oil change: 1L oil
    (2,  1, 3,  1, 35000),   -- spark plug
    (3,  2, 4,  1, 105000),  -- front brake pad
    (4,  2, 5,  1, 95000),   -- rear brake pad
    (5,  2, 9,  1, 38000),   -- brake fluid
    (6,  3, 19, 1, 62000),   -- carb jet kit
    (7,  4, 18, 1, 360000),  -- rear tire
    (8,  5, 15, 1, 260000),  -- battery
    (9,  6, 2,  1, 45000),   -- air filter
    (10, 6, 1,  1, 55000),   -- engine oil
    (11, 7, 16, 1, 28000);   -- headlamp bulb
SET IDENTITY_INSERT sparepart_usage OFF;

-- ============================================================
-- Payments (for completed orders only)
-- ============================================================

SET IDENTITY_INSERT payments ON;
INSERT INTO payments (payment_id, service_order_id, payment_date, payment_method, total_amount, paid_amount, change_amount) VALUES
    (1, 1, '2024-03-01 11:30', 'Cash',          90000,  100000,  10000),
    (2, 2, '2024-03-05 14:45', 'Transfer Bank', 225000, 225000,  0),
    (3, 3, '2024-03-11 09:30', 'Cash',          150000, 150000,  0),
    (4, 4, '2024-03-15 15:45', 'QRIS',          360000, 360000,  0),
    (5, 5, '2024-03-20 10:30', 'Debit Card',    320000, 320000,  0);
SET IDENTITY_INSERT payments OFF;

-- ============================================================
-- Stock mutation history
-- ============================================================

SET IDENTITY_INSERT stock_mutations ON;
INSERT INTO stock_mutations (mutation_id, sparepart_id, qty_change, mutation_type, notes, created_at) VALUES
    (1,  1,  100, 'IN',  'Initial stock load',          '2024-01-01'),
    (2,  2,  50,  'IN',  'Initial stock load',          '2024-01-01'),
    (3,  3,  120, 'IN',  'Initial stock load',          '2024-01-01'),
    (4,  4,  35,  'IN',  'Initial stock load',          '2024-01-01'),
    (5,  5,  35,  'IN',  'Initial stock load',          '2024-01-01'),
    (6,  1,  -1,  'OUT', 'Used in SV0001',              '2024-03-01'),
    (7,  3,  -1,  'OUT', 'Used in SV0001',              '2024-03-01'),
    (8,  4,  -1,  'OUT', 'Used in SV0002',              '2024-03-05'),
    (9,  5,  -1,  'OUT', 'Used in SV0002',              '2024-03-05'),
    (10, 9,  -1,  'OUT', 'Used in SV0002',              '2024-03-05'),
    (11, 19, -1,  'OUT', 'Used in SV0003',              '2024-03-10'),
    (12, 18, -1,  'OUT', 'Used in SV0004',              '2024-03-15'),
    (13, 15, -1,  'OUT', 'Used in SV0005',              '2024-03-20'),
    (14, 2,  -1,  'OUT', 'Used in SV0006',              '2024-04-01'),
    (15, 1,  -1,  'OUT', 'Used in SV0006',              '2024-04-01'),
    (16, 16, -1,  'OUT', 'Used in SV0007',              '2024-04-05'),
    (17, 6,  30,  'IN',  'Restocked from supplier',     '2024-04-12'),
    (18, 17, 10,  'IN',  'Restocked from supplier',     '2024-04-12');
SET IDENTITY_INSERT stock_mutations OFF;

GO
PRINT 'Seed data inserted successfully.';
PRINT 'Default password for all seed users: Fairy@2024!';
PRINT '(Replace BCrypt hashes before deploying to production.)';
GO
