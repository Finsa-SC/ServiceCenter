# 🛠️ Service Center Management System

A desktop-based Service Center Management System built with **.NET (Windows Forms)** and **SQL Server**, designed to manage daily operations of a motorcycle service workshop in a structured, efficient, and role-based manner.

This project is developed as a **training and competition-ready system** focusing on clear workflow, database integrity, and real-world business logic.

---

## 📌 Features Overview

### 1. User Management
- Manage application users with role-based access
- Roles include:
  - Developer
  - Admin
  - Technician
  - Cashier
- User status management (Active / Inactive)
- Secure login system
- Centralized session handling

---

### 2. Service Order (Front Desk)
- Register customer service requests
- Select existing customers or create new ones
- Select customer vehicles
- Input service complaints and estimated completion date
- Automatically generate unique service codes
- Initial service status tracking

---

### 3. Service Process (Assignment)
- View incoming service orders
- Assign available technicians to service orders
- Automatically update service status when assigned
- Technician availability is calculated based on unfinished assignments
- Transaction-based operations to ensure data consistency

---

### 4. Service Workshop (Technician Module)
- Technician can view assigned jobs only
- Display vehicle details and customer complaints
- Select service methods
- Manage sparepart usage using a cart-based system
- Write service notes per service method
- Finish service step-by-step
- Finalize service order when all tasks are completed

---

### 5. Payment
- Display full service order details (resolved foreign keys)
- Automatic total cost calculation
- Payment validation (paid amount must be sufficient)
- Change calculation
- Update service status after successful payment

---

### 6. Stock Management
- Sparepart management (CRUD)
- Supplier management
- Stock in operations
- Automatic stock mutation recording
- Minimum stock monitoring support
- Centralized stock data view

---

## 🗂️ Database Design

- Fully normalized relational database
- 20+ tables with strong foreign key relationships
- Transaction-safe operations
- Designed to support:
  - Service tracking
  - Technician performance
  - Sparepart usage
  - Payment history
  - Stock movement

Key tables include:
- `users`, `roles`, `technicians`
- `customers`, `vehicles`
- `service_orders`, `service_assignments`
- `services`, `service_order_details`
- `spareparts`, `suppliers`, `stock_mutations`
- `payments`

---

## 🔐 Role-Based Access Control

| Role        | Accessible Modules                                  |
|-------------|-----------------------------------------------------|
| Developer   | All modules                                         |
| Admin       | User, Service Order, Process, Stock, Reports        |
| Technician  | Service Workshop only                               |
| Cashier     | Payment, Service History                            |

---

## 🧠 System Flow Summary

1. Customer registers a service order
2. Admin assigns a technician
3. Technician performs service and records spareparts
4. Service is finalized
5. Cashier processes payment
6. Order status is completed

---

## 🛠️ Technologies Used

- **Language**: C#
- **Framework**: .NET (Windows Forms)
- **Database**: SQL Server
- **Architecture**: Layered (UI, Core, Database)
- **Data Access**: ADO.NET
- **Transactions**: SQL Transaction

---

## 🎯 Project Purpose

This project is built to:
- Simulate real-world service center operations
- Practice database-driven application design
- Prepare for **LKS (Lomba Kompetensi Siswa)** competition
- Focus on correctness, clarity, and maintainability

Advanced features such as analytics, audit logs, and notifications are intentionally excluded at this stage to maintain competition focus.

---

## 📎 Notes

- This project prioritizes **logic correctness over UI decoration**
- All business rules are implemented explicitly
- Designed to be extendable after competition

---

## 👤 Author

Developed by **Finsa-SC**  
GitHub: https://github.com/Finsa-SC

Project on development

