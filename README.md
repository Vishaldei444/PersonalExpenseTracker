# Personal Expense Tracker

A multi-form Windows desktop application built with C# and Windows Forms. The main form displays expenses in a table, and a second form lets users add new expenses or edit existing ones.

## Features

- View expenses by date, category, amount in rupees (₹), and description.
- Add a new expense using the **Add Expense** button.
- Select a row and click **Edit Expense** to update its details.
- Validate that a category is selected and the amount is greater than zero.
- Click **Cancel** to close the expense form without applying changes.

## Technologies Used

- C#
- Windows Forms
- Visual Studio 2022

## How to Run

1. Clone or download this repository.
2. Open `PersonalExpenseTracker.slnx` in Visual Studio 2022 with the **.NET desktop development** workload installed.
3. Press **F5** to build and run the application.

## How to Use

1. Click **Add Expense**.
2. Choose a date and category, enter an amount, and optionally add a description.
3. Click **Save**. The expense appears in the main table.
4. To update an expense, select its row and click **Edit Expense**. Change the details and click **Save**.

## Project Structure

| File | Purpose |
|---|---|
| `Program.cs` | Starts the application and opens the main form. |
| `Form1.cs` | Displays the expense list and handles adding and editing. |
| `Form1.Designer.cs` | Defines the main form layout. |
| `ExpenseForm.cs` | Loads existing details, validates input, and returns the saved expense to the main form. |
| `ExpenseForm.Designer.cs` | Defines the expense form layout. |
| `Expense.cs` | Defines the expense model. |

## Data Storage

Expenses are stored in memory during the current session. The list starts empty each time the application opens.

## Screenshot

![Personal Expense Tracker output](screenshots/expense-tracker.png)
