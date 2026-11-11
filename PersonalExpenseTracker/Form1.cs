using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Expense> expenses = new BindingList<Expense>();

        public Form1()
        {
            InitializeComponent();

            btnAddExpense.Click += AddExpense;
            btnEditExpense.Click += EditExpense;
        }

        protected override void OnLoad(EventArgs e)
        {
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = nameof(Expense.Date),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd-MM-yyyy" }
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = nameof(Expense.Category)
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount (₹)",
                DataPropertyName = nameof(Expense.Amount),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = nameof(Expense.Description)
            });

            dgvExpenses.DataSource = expenses;

            base.OnLoad(e);
        }

        private void AddExpense(object? sender, EventArgs e)
        {
            using (ExpenseForm form = new ExpenseForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    expenses.Add(form.SavedExpense);
                }
            }
        }

        private void EditExpense(object? sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0 ||
                !(dgvExpenses.SelectedRows[0].DataBoundItem is Expense selectedExpense))
            {
                MessageBox.Show(this, "Please select an expense to edit.");
                return;
            }

            int index = expenses.IndexOf(selectedExpense);

            using (ExpenseForm form = new ExpenseForm(selectedExpense))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    expenses[index] = form.SavedExpense;
                }
            }
        }
    }
}