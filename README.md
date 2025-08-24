# TravelAgency
A desktop application for managing a travel agency, built with **C# (.NET WinForms)** and **SQL Server**.  
This Application is for Travel Agency Employees to manage data easly they can use CRUD operations such as add edit and delete data 

## 🚀 Features
- Manage **Tours**, **Cities**, **Users**
- Create edit and delete **Tours**, **Cities**, **Users** (including **Edit Tour** functionality in `TourListForm`)
- Manage **Tours**, **Cities**, **Users**
- Full **CRUD** operations with validation
- Referential integrity enforced in SQL Server with foreign keys
- Soft Delete support (`IsActive = 0`)
- Stored Procedures for database operations


## 🛠️ Technologies & Tools
- **C#** → Core programming language for application logic, UI, and database connectivity
- **.NET Windows Forms** → For building the graphical user interface
- **SQL Server** → Database management system
- **SSMS (SQL Server Management Studio)** → For managing the database
- **ADO.NET** → For database connectivity and executing stored procedures
- **Dapper** → Lightweight ORM for efficient data mapping
- **Stored Procedures** → All CRUD operations are performed via stored procedures (no inline SQL)
- **Soft Delete principle** → Data is never physically deleted; instead, the `IsActive` (BIT) column is set to `0`
- **Git & GitHub** → Version control and collaboration

  ## 🎯 OOP Principles
The project is built following **Object-Oriented Programming** concepts:
- Use of **classes**, **objects**, **interfaces**, and **inheritance**
- Business logic controlled via **base (abstract) classes** and **interfaces**
- Separation of concerns for better maintainability and reusability

  ## 📐 Design Patterns Used
The application implements several well-known software design patterns:
- **Repository Pattern** → Provides a clean abstraction layer for data access
- **Unit of Work** → Manages transactions and coordinates the repositories
- **Factory Pattern** → Used for object creation logic
- **Singleton** → Ensures a single instance of specific services (e.g., database connection manager)
- **Lazy Loading** → Improves performance by loading objects only when needed

## 👤 Author
**Giorgi Kapanadze**  
🔗 [LinkedIn](https://www.linkedin.com/in/giorgi-kapanadze-b6303a2a1/) | [GitHub](https://github.com/GKapanadz)  

  
