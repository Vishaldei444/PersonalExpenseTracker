using System.Drawing;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class Form1
    {
        private Label lblTitle = null!;
        private DataGridView dgvExpenses = null!;
        private Button btnAddExpense = null!;
        private Button btnEditExpense = null!;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvExpenses = new DataGridView();
            btnAddExpense = new Button();
            btnEditExpense = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Personal Expense Tracker";

            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AutoGenerateColumns = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.Location = new Point(20, 50);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(620, 270);
            dgvExpenses.TabIndex = 0;

            btnAddExpense.Location = new Point(20, 335);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(120, 30);
            btnAddExpense.TabIndex = 1;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;

            btnEditExpense.Location = new Point(150, 335);
            btnEditExpense.Name = "btnEditExpense";
            btnEditExpense.Size = new Size(120, 30);
            btnEditExpense.TabIndex = 2;
            btnEditExpense.Text = "Edit Expense";
            btnEditExpense.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 385);
            Controls.Add(lblTitle);
            Controls.Add(dgvExpenses);
            Controls.Add(btnAddExpense);
            Controls.Add(btnEditExpense);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Expense Tracker";

            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}