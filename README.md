# Fairy Service Center — Management System

A desktop application for managing the daily operations of a motorcycle service workshop. Built with **.NET 8 (Windows Forms)** and **SQL Server**, it enforces role-based access across every stage of the service workflow — from front-desk intake through technician assignment, workshop execution, and cashier payment.

Developed as a training and competition project targeting **LKS (Lomba Kompetensi Siswa)** standards.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET 8) |
| UI | Windows Forms |
| Database | SQL Server (Express compatible) |
| Data access | ADO.NET + `Microsoft.Data.SqlClient` |
| Password hashing | BCrypt.Net-Next |
| Architecture | Layered — UI / Core / Database |

---

## Getting Started

### Prerequisites

- Windows 10 or later
- .NET 8 SDK
- SQL Server 2019+ (or SQL Server Express)
- Visual Studio 2022 (recommended)

### Database Setup

1. Open SQL Server Management Studio (or `sqlcmd`).
2. Run `init.sql` to create the `ServiceCenterDB` database and all tables.
3. Run `seed.sql` to populate reference data, demo users, customers, vehicles, spareparts, and sample orders.

```sql
-- In SSMS: File > Open > init.sql → Execute
-- File > Open > seed.sql → Execute
```

### Connection String

Update the connection string in `ServiceCenter/core/network/DBHelper.cs`:

```csharp
public static readonly string connectionString =
    "Server=YOUR_SERVER\\SQLEXPRESS;Database=ServiceCenterDB;" +
    "Integrated Security=true;TrustServerCertificate=true";
```

### Default Login (Seed Data)

| Role | Email | Password |
|---|---|---|
| Developer | `dev@fairysc.com` | `Fairy@2024!` |
| Admin | `admin@fairysc.com` | `Fairy@2024!` |
| Technician | `budi@fairysc.com` | `Fairy@2024!` |
| Cashier | `sari@fairysc.com` | `Fairy@2024!` |

> **Note:** Seed passwords use a single BCrypt hash for convenience. Generate unique hashes in production using `PasswordHelper.Hash(plain)`.

---

## Role-Based Access

| Role | Accessible Modules |
|---|---|
| Developer | All modules |
| Admin | User Management, Service Order, Service Process, Stock Management, Reports |
| Technician | Service Workshop only |
| Cashier | Service Payment, Service Order, Service Process |
| Supplier | Stock Management |

---

## Module Overview

### 1. User Management
Create and manage application users. Assign roles, toggle active/inactive status, and attach a profile photo. Technician-specific fields (skill level, hire date) appear automatically when the Technician role is selected.

### 2. Service Order (Front Desk)
Register incoming vehicles. Search or create a customer, select or add their vehicle, enter the complaint, set an estimated completion date, and submit. The system auto-generates a unique service code.

### 3. Service Process (Assignment)
View all unassigned service orders. Open the free-technician picker — it filters out any technician who already has an open assignment — then confirm to assign. The order status updates to **In Progress** automatically inside a SQL transaction.

### 4. Service Workshop (Technician View)
Technicians see only their own active assignment. They select a service method from the catalog, add spareparts from an interactive cart (stock decrements live), write notes, and mark the step finished. When all steps are done they finalize the order, which triggers a stock deduction transaction and sets the status to **Ready for Payment**.

### 5. Payment (Cashier)
Lists all orders at **Ready for Payment** status. Click a row to populate the total, choose a payment method, enter the paid amount, and the change calculates automatically. Confirming runs a transaction that inserts the payment record and marks the order **Completed**.

### 6. Stock Management
Three sub-views:
- **Stock In** — shows items at or below a configurable threshold. Opens an animated stock-in dialog to increase quantity.
- **Sparepart Management** — full CRUD for spareparts with pricing and supplier linkage.
- **Supplier Management** — manage supplier contact details.

### 7. Service History
- **Order History** — searchable / filterable list of completed orders with a detail popup showing spareparts used, services performed, cost, and processing time.
- **Technician Performance** — aggregated stats per technician (orders completed, minutes worked).

---

## Database Design

Fully normalized, 20+ tables, all relationships enforced with foreign keys. Key tables:

```
users, roles, user_status
customers, vehicles, vehicle_brands
service_orders, service_assignments, service_status
service_order_details, services, service_categories
spareparts, sparepart_price, sparepart_unit, sparepart_usage
suppliers, stock_mutations
payments
```

Multi-step operations (assignment, finalization, payment) run inside explicit SQL transactions with `BEGIN TRANSACTION / COMMIT / ROLLBACK` blocks.

---

## Service Workflow

```
Customer arrives
      │
      ▼
[Service Order] — front desk creates order, generates code
      │
      ▼
[Service Process] — admin picks a free technician, assigns order
      │
      ▼
[Service Workshop] — technician selects services, adds spareparts
      │
      ▼
[Ready for Payment] — order finalized, total calculated
      │
      ▼
[Payment] — cashier processes payment
      │
      ▼
[Completed] — order archived in Service History
```

---

## Project Structure

```
ServiceCenter/
├── core/
│   ├── network/        DBHelper.cs — ADO.NET data access
│   └── util/           Validation, UI helpers, toast, code generator
├── ServiceOrder/       Front-desk forms and UCs
├── ServiceProcess/     Assignment forms and UCs
├── ServiceWorkshop/    Technician module, cart model, sparepart model
├── ServicePayment/     Payment UC
├── ServiceHistory/     Order history and technician performance UCs
├── StockManagement/    Sparepart, supplier, and stock-in UCs
├── UserNamagement/     User management UC and form
├── UserSession.cs      Static session holder (userId, role, photo…)
├── Program.cs          Entry point
└── Form1.cs            Shell — nav panel, panel switching, profile slide-in
```

---

## Known Limitations

- Image paths for profile photos are stored as absolute filesystem paths — works for single-machine dev, needs a shared path or blob storage for multi-user deployments.
- A few edit-image paths in `ProfileUC.cs` are still hardcoded to the original dev machine; update them before running on a new machine.
- No audit log or soft-delete yet — deleting a user is permanent.

---

## Author

Developed by **Finsa Kusuma Putra**  
GitHub: [Finsa-SC](https://github.com/Finsa-SC)

> Project is under active development. Advanced features (analytics dashboards, audit logs, push notifications) are deferred to a post-competition phase.
