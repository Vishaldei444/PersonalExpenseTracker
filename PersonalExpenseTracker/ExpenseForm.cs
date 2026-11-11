using System;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class ExpenseForm : Form
    {
        public Expense SavedExpense { get; private set; } = new Expense();

        public ExpenseForm()
        {
            InitializeComponent();

            btnSave.Click += SaveExpense;
        }

        public ExpenseForm(Expense expense) : this()
        {
            Text = "Edit Expense";
            dtpExpenseDate.Value = expense.Date;
            cmbCategory.SelectedItem = expense.Category;
            nudAmount.Value = expense.Amount;
            txtDescription.Text = expense.Description;
        }

        private void SaveExpense(object? sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Please select a category.");
                cmbCategory.Focus();
                return;
            }

            if (nudAmount.Value <= 0)
            {
                MessageBox.Show(this, "Please enter an amount greater than zero.");
                nudAmount.Focus();
                return;
            }

            SavedExpense = new Expense
            {
                Date = dtpExpenseDate.Value.Date,
                Category = cmbCategory.Text,
                Amount = nudAmount.Value,
                Description = txtDescription.Text.Trim()
            };

            DialogResult = DialogResult.OK;
        }
    }
}