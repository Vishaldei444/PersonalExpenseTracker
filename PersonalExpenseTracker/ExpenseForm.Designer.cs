using System.Drawing;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    partial class ExpenseForm
    {
        private Label lblDate = null!;
        private Label lblCategory = null!;
        private Label lblAmount = null!;
        private Label lblDescription = null!;
        private DateTimePicker dtpExpenseDate = null!;
        private ComboBox cmbCategory = null!;
        private NumericUpDown nudAmount = null!;
        private TextBox txtDescription = null!;
        private Button btnSave = null!;
        private Button btnCancel = null!;

        private void InitializeComponent()
        {
            lblDate = new Label();
            lblCategory = new Label();
            lblAmount = new Label();
            lblDescription = new Label();
            dtpExpenseDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            nudAmount = new NumericUpDown();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();

            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 24);
            lblDate.Name = "lblDate";
            lblDate.Text = "Date";

            dtpExpenseDate.Format = DateTimePickerFormat.Short;
            dtpExpenseDate.Location = new Point(130, 20);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(220, 23);
            dtpExpenseDate.TabIndex = 0;

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 62);
            lblCategory.Name = "lblCategory";
            lblCategory.Text = "Category";

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new object[]
            {
                "Food", "Travel", "Shopping", "Bills", "Other"
            });
            cmbCategory.Location = new Point(130, 58);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 23);
            cmbCategory.TabIndex = 1;

            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 100);
            lblAmount.Name = "lblAmount";
            lblAmount.Text = "Amount (₹)";

            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(130, 96);
            nudAmount.Maximum = 1000000;
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(220, 23);
            nudAmount.TabIndex = 2;

            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "Description";

            txtDescription.Location = new Point(130, 134);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 23);
            txtDescription.TabIndex = 3;

            btnSave.Location = new Point(130, 177);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;

            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(250, 177);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;

            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(375, 230);
            Controls.Add(lblDate);
            Controls.Add(dtpExpenseDate);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblAmount);
            Controls.Add(nudAmount);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExpenseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Expense";

            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}