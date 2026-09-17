namespace RentFlow_Application.Forms
{
    partial class AddExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddExpense = new Label();
            lblExpenseCategory = new Label();
            lblProperty = new Label();
            lblDescription = new Label();
            lblAmount = new Label();
            cmbExpenseCategory = new ComboBox();
            cmbProperty = new ComboBox();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            lblDate = new Label();
            txtDate = new TextBox();
            btnSaveExpense = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAddExpense
            // 
            lblAddExpense.AutoSize = true;
            lblAddExpense.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddExpense.Location = new Point(34, 22);
            lblAddExpense.Name = "lblAddExpense";
            lblAddExpense.Size = new Size(182, 38);
            lblAddExpense.TabIndex = 0;
            lblAddExpense.Text = "Add Expense";
            // 
            // lblExpenseCategory
            // 
            lblExpenseCategory.AutoSize = true;
            lblExpenseCategory.Location = new Point(34, 73);
            lblExpenseCategory.Name = "lblExpenseCategory";
            lblExpenseCategory.Size = new Size(127, 20);
            lblExpenseCategory.TabIndex = 1;
            lblExpenseCategory.Text = "Expense Category";
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Location = new Point(34, 161);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(65, 20);
            lblProperty.TabIndex = 2;
            lblProperty.Text = "Property";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(34, 248);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(35, 411);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(94, 20);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount ZAR";
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Items.AddRange(new object[] { "Maintenance", "Insurance", "Security", "Utilities", "Other" });
            cmbExpenseCategory.Location = new Point(34, 112);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(434, 28);
            cmbExpenseCategory.TabIndex = 5;
            // 
            // cmbProperty
            // 
            cmbProperty.FormattingEnabled = true;
            cmbProperty.Location = new Point(34, 203);
            cmbProperty.Name = "cmbProperty";
            cmbProperty.Size = new Size(434, 28);
            cmbProperty.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 278);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(433, 111);
            txtDescription.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(41, 438);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(427, 27);
            txtAmount.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(34, 496);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(39, 531);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(429, 27);
            txtDate.TabIndex = 10;
            // 
            // btnSaveExpense
            // 
            btnSaveExpense.Location = new Point(45, 600);
            btnSaveExpense.Name = "btnSaveExpense";
            btnSaveExpense.Size = new Size(423, 68);
            btnSaveExpense.TabIndex = 11;
            btnSaveExpense.Text = "Save Expense";
            btnSaveExpense.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(518, 622);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 46);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 735);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveExpense);
            Controls.Add(txtDate);
            Controls.Add(lblDate);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(cmbProperty);
            Controls.Add(cmbExpenseCategory);
            Controls.Add(lblAmount);
            Controls.Add(lblDescription);
            Controls.Add(lblProperty);
            Controls.Add(lblExpenseCategory);
            Controls.Add(lblAddExpense);
            Name = "AddExpense";
            Text = "AddExpense";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddExpense;
        private Label lblExpenseCategory;
        private Label lblProperty;
        private Label lblDescription;
        private Label lblAmount;
        private ComboBox cmbExpenseCategory;
        private ComboBox cmbProperty;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private Label lblDate;
        private TextBox txtDate;
        private Button btnSaveExpense;
        private Button btnCancel;
    }
}