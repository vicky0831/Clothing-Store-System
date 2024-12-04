# Clothing Store System

This project is designed to provide an online ordering and delivery system for a clothing outlet. It includes features like online ordering, total price calculation, database storage, order printing, and distance calculation(outlet to user address).

## Features

- **Online Ordering**: Users can browse and select clothing items to add to their cart.
- **Total Price Calculation**: The system calculates the total cost based on the selected items.
- **Database Storage**: All order details are stored in a SQL Server database.
- **Order Printing**: The system generates an order receipt for the user.
- **Distance Calculation**: The system calculates delivery distance for the order.

## Technologies Used

- **Programming Languages**: Visual Basic, SQL
- **Frameworks**: .NET Framework
- **Database**: Microsoft SQL Server

## Process Using the System
- **Main Page**: User navigates to login or location page.
- **Login Page**: User enters credentials to access the shopping interface.
- **Home Page**: Browse products and add to the cart.
- **Cart Page**: Review and proceed to checkout.
- **Address Page**: Enter or modify delivery details.
- **Distance Calculation**: Using Nominatim API for geocoding and OSRM API for routing.
- **Invoice Page**: Printable invoice with all order details.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/Clothing-Store-System.git

### A. Set Up the Database

#### Install SQL Server
If you haven't already, you'll need to install **Microsoft SQL Server** or **SQL Server Express**. You can download the installer from the official [Microsoft SQL Server website](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).

#### Create the Database
2. **Open SQL Server Management Studio (SSMS)**:
    - Launch **SSMS** on your computer.
    - Connect to your SQL Server instance using your login credentials.

3. **Create a New Database**:

3. **Execute the SQL Scripts**:
    - Navigate to the **SQL Coding** directory in your project.
    - Open the SQL scripts for creating tables (such as `create_products.sql`, `create_users.sql`, `create_cart.sql`, etc.).
    - Copy and paste the SQL code into the **Query Editor** in SSMS.
    - Execute the script by clicking **Execute** or pressing `F5`.

4. **Configure the Connection String**:
Once the database is set up, ensure the connection string in your application is configured to connect to the `Mini_Project` database. The connection string typically looks like this:

## Executable: Download the App

You can download the executable file and its dependencies here:

[Download the App](https://github.com/vicky0831/Clothing-Store-System/releases)


