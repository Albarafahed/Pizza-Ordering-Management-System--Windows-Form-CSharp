# Pizza (Windows Forms)

Lightweight Windows Forms application for creating and managing food orders (Pizza, Desserts, Juices) with local JSON persistence.

## Overview

This project is a .NET Framework 4.8 Windows Forms application that provides a simple point-of-sale style UI to add orders, view and print orders, and update delivery status. Orders are stored locally in a JSON file (orders.json) using Newtonsoft.Json.

Key functionality (implemented in code):
- User login (LoginForm) with hard-coded credentials: `Admin` / `A1234` and `User 1` / `a1234`.
- Main menu (MainMenu) to open order forms and management screens.
- Order creation for: Pizza, Dessert, Juice (OrderPizzaForm, OrderDessertForm, OrderJuiceForm).
- Order management and print preview (OrdersForm) with filtering by print state and customer.
- Remote/delivery status management (RemoteForm) with status transitions: Pending -> Delivering -> Delivered.
- Local JSON persistence handled by JsonDatabase.cs (orders.json).
- Product model: OrderId, CustomerId, Kind, Name, Price, Size, Topping, Amount, Status, IsPrinted.
- ShoppingCartService provides add/remove/save and basic query helpers.

Note: The UI contains Arabic text for some labels and messages as present in the source.

## Requirements

- .NET Framework 4.8
- Visual Studio (any edition that supports .NET Framework Windows Forms projects)
- NuGet package: Newtonsoft.Json (project references version 13.0.4)

## Build and run

1. Open `Pizza.csproj` in Visual Studio.
2. Restore NuGet packages (Visual Studio will restore automatically or use `Restore NuGet Packages`).
3. Build the solution.
4. Run the application. The program entry point launches LoginForm (Program.cs).

## Default credentials

- Admin: username `Admin`, password `A1234`
- User: username `User 1`, password `a1234`

## Data persistence

- Orders are saved to `orders.json` in the application's working directory by JsonDatabase.SaveOrders.
- To reset stored orders, stop the application and delete `orders.json`.

## Project structure (relevant files)

- Program.cs — application entry point
- Product.cs — order model
- JsonDatabase.cs — load/save orders to JSON (uses Newtonsoft.Json)
- ShoppingCartService.cs — in-memory collection and helpers for orders
- LoginForm.* — login UI
- MainMenu.* — main navigation UI
- OrderPizzaForm.*, OrderDessertForm.*, OrderJuiceForm.* — order creation screens
- OrdersForm.* — view / print / delete orders
- frmRemoteDelivery.* (RemoteForm) — update delivery status
- packages.config — NuGet package references

## Usage notes

- Printing uses PrintPreviewDialog and marks orders as printed (IsPrinted = true) after printing.
- Delivery status updates are persisted via ShoppingCartService.Save.
- Customer IDs are auto-incremented using existing orders (GetNextCustomerId).

## Dependency

- Newtonsoft.Json (see packages.config)

If you need the README adjusted (formatting, additional details such as screenshots or contribution guidelines), specify what to include.