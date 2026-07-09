# 🍕 Pizza Ordering Management System - WinForms Desktop Application

![C#](https://img.shields.io/badge/Language-C%23-blue)
![.NET Framework](https://img.shields.io/badge/Framework-.NET%20Framework%204.8-purple)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-green)
![JSON](https://img.shields.io/badge/Storage-JSON%20Persistence-orange)
![Architecture](https://img.shields.io/badge/Architecture-Layered%20Design-blue)
![Printing](https://img.shields.io/badge/Printing-PrintDocument-red)
![Version Control](https://img.shields.io/badge/Version%20Control-Git-orange)

A desktop food ordering management application built using **C# Windows Forms** and **.NET Framework 4.8**.

The application allows users to create and manage food orders including **Pizza, Juice, and Dessert**, while providing order storage, printing, filtering, and delivery status management.

The system uses a simple layered architecture consisting of UI forms, a service layer for order management, and local JSON-based persistence.

---

# 📑 Table of Contents

* [Features](#-features)
* [Technology Stack](#-technology-stack)
* [Architecture](#-architecture)
* [Order Management](#-order-management)
* [Printing System](#-printing-system)
* [Delivery Tracking](#-delivery-tracking)
* [Design Patterns](#-design-patterns)
* [Data Storage](#-data-storage)
* [Installation](#-installation)
* [Project Structure](#-project-structure)
* [Limitations](#-limitations)
* [Future Improvements](#-future-improvements)
* [Contact](#-contact)

---

# 🚀 Features

# 🔐 User Login

The application provides a login screen.

Available credentials:

```text
Admin
Password: A1234

User 1
Password: a1234
```

Note:

* Credentials are currently stored directly in the application code.

---

# 🏠 Main Menu

The main menu provides navigation between application modules.

Features:

* Open order forms.
* Display child forms inside a panel.
* Manage application workflow.

Main form:

```text
MainMenu
```

---

# 🍕 Pizza Orders

Users can create customizable pizza orders.

## Available Options

* Pizza size.
* Toppings.
* Crust type.
* Quantity.
* Price calculation.

Order data:

```text
Product
Size
Topping
Amount
Price
```

---

# 🧃 Juice Orders

The system supports juice ordering.

Features:

* Select juice type.
* Choose size.
* Specify quantity.
* Calculate total price.

---

# 🍰 Dessert Orders

The application supports dessert orders.

Features:

* Dessert type.
* Size selection.
* Toppings.
* Quantity.
* Automatic price calculation.

---

# 📦 Order Management

Each order contains:

```text
OrderId
CustomerId
Kind
Name
Price
Size
Topping
Amount
Status
IsPrinted
```

---

# 👤 Customer Management

The system generates customer IDs automatically.

Implemented method:

```csharp
ShoppingCartService.GetNextCustomerId()
```

Responsibilities:

* Generate unique customer identifier.
* Associate multiple orders with the same customer.

---

# 🛒 Shopping Cart Service

The application uses a service layer for order management.

Main class:

```text
ShoppingCartService
```

Responsibilities:

* Store orders in memory.
* Add orders.
* Remove orders.
* Retrieve orders.
* Save changes.
* Load existing orders.

---

# 🖨 Printing System

The application supports printing customer orders.

Features:

* Select customer orders.
* Preview before printing.
* Generate printable output.
* Calculate total price.
* Mark orders as printed.

Technology:

```text
System.Drawing.Printing.PrintDocument
```

---

# 🚚 Delivery Status Management

The Remote module manages delivery progress.

Supported statuses:

```text
Pending
   ↓
Delivering
   ↓
Delivered
```

Features:

* Filter orders by customer.
* Filter by status.
* Update delivery progress.
* Save status changes.

---

# 📊 Orders Management Form

The OrdersForm provides:

Features:

* Display orders using DataGridView.
* Filter by:

  * Printed orders.
  * Unprinted orders.
  * Customer ID.
* Delete selected orders.
* Print customer orders.
* Color rows based on customer grouping.

---

# 🏛 Architecture

The application follows a simple layered architecture.

```text
Pizza Application

        |
        ↓

 UI Layer
(WinForms Forms)

        |
        ↓

 Service Layer
ShoppingCartService

        |
        ↓

 Persistence Layer
JsonDatabase

        |
        ↓

 orders.json
```

---

# 🖥 UI Layer

Contains Windows Forms screens.

Forms:

```text
LoginForm
MainMenu
OrderPizzaForm
OrderJuiceForm
OrderDessertForm
OrdersForm
RemoteForm
```

Responsibilities:

* User interaction.
* Display information.
* Handle events.
* Navigate between screens.

---

# ⚙ Service Layer

Main component:

```text
ShoppingCartService
```

Responsibilities:

* Manage order collection.
* Provide CRUD operations.
* Coordinate saving/loading operations.

The service works as a small repository abstraction for orders.

---

# 💾 Persistence Layer

Component:

```text
JsonDatabase
```

Responsibilities:

* Read JSON data.
* Write JSON data.
* Handle local storage operations.

Storage file:

```text
orders.json
```

---

# 🧩 Design Patterns & Programming Style

## Dependency Injection

Child forms receive:

```text
ShoppingCartService
```

instance from the parent form.

---

## Repository-Like Pattern

`ShoppingCartService` acts as a lightweight repository:

Provides:

```text
Add
Remove
Get
Save
Load
```

---

## POCO / DTO Model

Main entity:

```text
Product
```

Contains order data used throughout the application.

---

## Event-Driven UI

The application depends on WinForms events:

Examples:

```csharp
Button.Click
Form.Load
PrintDocument.PrintPage
```

---

# 🛠 Technology Stack

| Category         | Technology                 |
| ---------------- | -------------------------- |
| Language         | C#                         |
| Framework        | .NET Framework 4.8         |
| UI               | Windows Forms              |
| Storage          | JSON File                  |
| JSON Library     | Newtonsoft.Json 13.0.4     |
| Printing         | System.Drawing.Printing    |
| IDE              | Visual Studio              |
| Build            | MSBuild                    |
| Application Type | WinExe Desktop Application |

---

# 🗄 Data Storage

The application does not use an external database.

Storage:

```text
orders.json
```

Behavior:

* Orders loaded when ShoppingCartService starts.
* Changes saved back to JSON file.
* Local file-based persistence.

---

# ⚙ Installation

## Requirements

Install:

* Windows Operating System.
* Visual Studio 2019 or newer.
* .NET Framework 4.8 Developer Pack.

---

## Setup

1. Clone repository:

```bash
git clone <repository-url>
```

2. Open solution:

```text
Pizza.sln
```

3. Restore NuGet packages.

Required package:

```text
Newtonsoft.Json 13.0.4
```

4. Build solution.

5. Run application.

Startup:

```text
Program.cs
        ↓
LoginForm
```

---

# 📂 Project Structure

```text
Pizza
│
├── Pizza.csproj
├── Program.cs
│
├── Product.cs
├── ShoppingCartService.cs
├── JsonDatabase.cs
│
├── LoginForm
│
├── MainMenu
│
├── OrderPizzaForm
│
├── OrderJuiceForm
│
├── OrderDessertForm
│
├── OrdersForm
│
├── RemoteForm
│
├── packages
│   └── Newtonsoft.Json
│
└── README.md
```

---

# ⚠️ Limitations

Current limitations:

* Authentication uses hard-coded credentials.
* No user management system.
* No encryption for stored data.
* JSON file has no concurrency handling.
* Designed for single-user usage.
* No external database.
* No automated tests.
* No CI/CD configuration.
* No license file included.
* Configuration values are stored inside code.

---

# 🔮 Future Improvements

Possible improvements:

* Add SQL Server database.
* Implement proper user authentication.
* Add role-based authorization.
* Separate business logic from UI.
* Add repository interfaces.
* Add unit tests.
* Add logging system.
* Add order reports.
* Add inventory management.
* Add online ordering support.
* Add payment integration.
* Add application configuration files.

---

# 📧 Contact

**Albara Fahed Alharissy**

Software Engineer | C# .NET Developer

GitHub:

https://github.com/Albarafahed

LinkedIn:

https://www.linkedin.com/in/albara-csharp-developer/
