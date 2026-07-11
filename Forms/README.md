# Pizza Ordering Management System

A Windows Forms (.NET Framework 4.8) desktop application for creating and managing simple pizza, dessert, and juice orders. Orders are stored in a local JSON file and can be printed or updated.

## Features

- Create orders for Pizza, Desserts, and Juices with options (size, toppings, crust, quantity).
- Grouping of orders by customer ID.
- Print orders with a simple print preview and per-kind pages.
- Mark orders as printed; filter printed/new orders.
- Update order status for remote/delivery flow (Pending -> Delivering -> Delivered).
- Persist orders to a local JSON file (orders.json) using Newtonsoft.Json.
- Simple login screen with two hard-coded users for access control.

## Screenshots

(Placeholders — add screenshots in the `Resources/` folder and update paths below)

- Screenshot: Login screen — `screenshots/login.png` (placeholder)
- Screenshot: Main menu — `screenshots/mainmenu.png` (placeholder)
- Screenshot: Order form — `screenshots/order.png` (placeholder)
- Screenshot: Orders / Print preview — `screenshots/orders.png` (placeholder)

## Tech Stack

- .NET Framework 4.8
- Windows Forms (WinForms)
- C#
- Newtonsoft.Json (v13.0.4) for JSON serialization

## Architecture Overview

This is a small, single-process WinForms desktop application with a thin service layer:

- UI: Multiple WinForms forms (LoginForm, MainMenu, Order forms, OrdersForm, RemoteForm).
- Service: ShoppingCartService manages in-memory Product objects and persists to a JSON file via JsonDatabase.
- Persistence: JsonDatabase reads/writes a single `orders.json` file in the application's working directory.

There is no client/server, no web API, and no external database.

## Project Structure

Top-level files (selected important files):

- Pizza.csproj
- Program.cs — application entry point (starts LoginForm).
- LoginForm.cs — login UI and basic auth.
- MainMenu.cs — main navigation and container for order forms.
- OrderPizzaForm.cs, OrderDessertForm.cs, OrderJuiceForm.cs — order creation UIs.
- OrdersForm.cs — listing, filtering, printing orders.
- frmRemoteDelivery.cs (RemoteForm) — update order status for delivery.
- Product.cs — Product model used by the app.
- ShoppingCartService.cs — in-memory collection and persistence wrapper.
- JsonDatabase.cs — JSON persistence (reads/writes orders.json).
- packages.config — declares Newtonsoft.Json dependency.
- App.config — application target runtime (net4.8).
- Resources/ — images used by the app.

Designer (.Designer.cs) and .resx files accompany the WinForms forms and store UI layout/resources.

## Prerequisites

- Microsoft Visual Studio (tested with Visual Studio Community 2022/2026) with .NET desktop development workload.
- .NET Framework 4.8 targeting pack (installed via Visual Studio installer or Windows SDK).

## Installation

Clone the repository and open the solution or project file in Visual Studio:

```powershell
git clone <repository-url>
cd <repository-folder>
# Open Pizza.csproj in Visual Studio or open the folder
```

## Configuration

Required environment variables: None.

Application configuration files:

- App.config — targets .NET Framework 4.8.
- orders.json — data file created at runtime in the application's working directory. If missing, the app starts with an empty order list.

If additional configuration is required (e.g., to change the orders file location), the code must be updated — currently the path is hard-coded in JsonDatabase.cs:

```csharp
private static string filePath = "orders.json";
```

## Running the Project

Development

1. Open the project (Pizza.csproj) in Visual Studio.
2. Build (Build -> Build Solution).
3. Start debugging (F5) or run without debugging (Ctrl+F5).

Production

- The project builds to a Windows desktop executable in the bin\Debug or bin\Release folder. Copy the executable and dependencies to the target machine.
- Ensure the directory is writable so the application can create/update `orders.json`.

## Authentication / Authorization

- The application uses hard-coded credentials in LoginForm.cs:

```text
Username: Admin  Password: A1234
Username: User 1 Password: a1234
```

- There is no role-based enforcement beyond enabling/disabling certain UI elements for the Admin persona in MainMenu (this is hard-coded and limited).

## API Overview

None. The app is a standalone desktop application and does not expose or consume HTTP APIs.

## Database

- Storage: Local JSON file named `orders.json` (persisted by JsonDatabase.SaveOrders and JsonDatabase.LoadOrders).
- Schema: List<Product> where Product is defined in Product.cs.

Example Product JSON (approximate):

```json
[
  {
	"OrderId": 1,
	"CustomerId": 1,
	"Kind": "Pizza",
	"Name": "Custom Pizza",
	"Price": 12.5,
	"Size": "Medium",
	"Topping": "Extra Cheese",
	"Amount": 1,
	"Status": "Pending",
	"IsPrinted": false
  }
]
```

## Build

Use Visual Studio Build -> Build Solution. The project targets .NET Framework 4.8.

Command-line MSBuild (example):

```powershell
msbuild Pizza.csproj /p:Configuration=Release
```

## Deployment

- Build a Release and copy the contents of bin\Release to the target machine.
- Ensure the target machine has .NET Framework 4.8 installed.
- The app requires write access to its working folder to persist orders.json.

## Testing

- There are no automated unit or integration tests included in the repository.
- Manual testing steps:
  - Launch app, log in with the provided credentials.
  - Create orders in each form and verify they appear in Orders and Remote forms.
  - Use print preview to validate printed output.
  - Update status in Remote form and verify persistence.

## Usage Examples

- Creating a pizza order:
  1. Log in.
  2. Open "Pizza" from the main menu.
  3. Select size, toppings, crust, quantity.
  4. Click "Add Order" (or similar). The order is saved to `orders.json`.

- Printing orders:
  1. Open Orders form.
  2. Select a customer row.
  3. Click Print to open Print Preview, then print.

## Troubleshooting

- If orders do not persist, ensure the executable has permission to write the working directory and that `orders.json` is not locked by another process.
- If the app crashes while parsing prices, confirm price strings are in the expected format (the code sometimes trims leading '$' characters before parsing).
- If UI layout looks incorrect, confirm you opened the correct project configuration and that the .Designer.cs files are present.

## Security Notes

Known security issues and considerations:

- Hard-coded credentials in source code. Replace with a secure authentication mechanism.
- No password hashing or secure storage.
- No input validation / sanitization for user inputs; parsing could throw exceptions.
- `orders.json` is stored unencrypted on disk.
- Concurrent access is not handled; multiple instances or processes writing to the file may cause data loss.

## Known Limitations

- Single-user, single-process storage using a JSON file (no server or DB).
- No automated tests.
- Hard-coded credentials and role logic.
- Minimal error handling and validation.
- UI code and business logic are mixed (tight coupling between forms and ShoppingCartService).
- No localization beyond Arabic/English labels spread across the UI.

## Future Improvements

- Replace JSON file with a proper database (SQLite, SQL Server, or a lightweight embedded DB).
- Introduce dependency injection for services and improve separation of concerns (UI vs business logic).
- Implement proper authentication (user store, hashed passwords, roles).
- Add unit and integration tests.
- Improve error handling and input validation.
- Add concurrency control for file access or switch to transactional storage.
- Add configuration option for the orders file path and logging.

## Contributing

- Fork the repository and submit pull requests.
- Prefer changes that separate UI from business logic and introduce tests.

## License

- Not specified in the repository. License: Unknown / Needs Documentation.

## Author

- Not specified in the repository files. Author: Unknown / Needs Documentation.



Notes / Assumptions

- The analysis is based solely on the repository files present. Anything not present in the codebase (license, CI, tests, external integrations) is marked "Unknown / Needs Documentation." If you want, I can:
  - Add a LICENSE file (specify which license).
  - Add a sample `orders.json` file.
  - Add basic unit tests for ShoppingCartService and JsonDatabase.
