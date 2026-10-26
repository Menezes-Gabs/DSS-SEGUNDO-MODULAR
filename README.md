# DSS RESTAURANTE

# Restaurant Sales System

A restaurant sales and billing system developed in C# using Windows Forms.

## About the Project

This project was developed during the Technical Course in Systems Development to practice object-oriented programming, graphical interfaces, classes, methods, events, and calculations using C#.

The system allows the user to select the products consumed by a customer, enter the quantity of each product, calculate the total bill, apply a birthday discount, and generate a receipt.

## Features

- Customer name registration
- Birth date information
- Product selection
- Quantity control for each product
- Automatic bill calculation
- 10% birthday discount
- Total amount display
- Receipt generation
- Display of consumed products and quantities
- Bill finalization

## Products

| Product | Price |
|---|---:|
| Lunch | R$ 35.00 |
| Soft Drink | R$ 12.00 |
| Beer | R$ 15.00 |
| Juice | R$ 11.50 |

## Birthday Discount

Customers whose birthday matches the purchase date receive a **10% discount** on the total bill.

The system checks the customer's day and month of birth and automatically applies the discount when the conditions are met.

## Technologies

- C#
- .NET
- Windows Forms
- Visual Studio

## Project Structure

The project uses classes to organize the system's responsibilities.

The `Conta` class is responsible for calculating the products and applying the discount.

The `ClassRecibo` class is responsible for generating the receipt text using `StringBuilder`.

The `FrmRecibo` form displays the generated receipt to the customer.

## How to Run

1. Clone this repository.
2. Open the `.sln` file in Visual Studio.
3. Wait for the project to load.
4. Run the project using `F5` or the Start button in Visual Studio.

## Purpose

The purpose of this project is to practice C# and Windows Forms concepts, including classes, methods, conditional statements, events, form controls, and calculations.

## Author

Developed by **Gabriel Menezes**.

Educational project developed as part of the Technical Course in Systems Development.

Menu Close
<img width="362" height="135" alt="image" src="https://github.com/user-attachments/assets/1960d41c-e6fe-46fa-b750-ddbc5c0918a0" />
Menu Open
<img width="549" height="368" alt="image" src="https://github.com/user-attachments/assets/dafe7a7e-6d48-4f36-8636-d8cbed80c4fe" />
Form
<img width="549" height="355" alt="image" src="https://github.com/user-attachments/assets/20b3c1f8-aadf-42ef-a415-9223eaf131da" />
Receipt / Exit
<img width="224" height="445" alt="image" src="https://github.com/user-attachments/assets/fb83167a-5a4c-4456-80d7-ff7fc6a4c6bf" />
