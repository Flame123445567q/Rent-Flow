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
            lblAddExpense.Location = new Point(42, 28);
            lblAddExpense.Margin = new Padding(4, 0, 4, 0);
            lblAddExpense.Name = "lblAddExpense";
            lblAddExpense.Size = new Size(214, 45);
            lblAddExpense.TabIndex = 0;
            lblAddExpense.Text = "Add Expense";
            // 
            // lblExpenseCategory
            // 
            lblExpenseCategory.AutoSize = true;
            lblExpenseCategory.Location = new Point(42, 91);
            lblExpenseCategory.Margin = new Padding(4, 0, 4, 0);
            lblExpenseCategory.Name = "lblExpenseCategory";
            lblExpenseCategory.Size = new Size(153, 25);
            lblExpenseCategory.TabIndex = 1;
            lblExpenseCategory.Text = "Expense Category";
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.Location = new Point(42, 201);
            lblProperty.Margin = new Padding(4, 0, 4, 0);
            lblProperty.Name = "lblProperty";
            lblProperty.Size = new Size(80, 25);
            lblProperty.TabIndex = 2;
            lblProperty.Text = "Property";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(42, 310);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(44, 514);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(115, 25);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount ZAR";
            // 
            // cmbExpenseCategory
            // 
            cmbExpenseCategory.FormattingEnabled = true;
            cmbExpenseCategory.Items.AddRange(new object[] { "Maintenance", "Insurance", "Security", "Utilities", "Other" });
            cmbExpenseCategory.Location = new Point(42, 140);
            cmbExpenseCategory.Margin = new Padding(4);
            cmbExpenseCategory.Name = "cmbExpenseCategory";
            cmbExpenseCategory.Size = new Size(542, 33);
            cmbExpenseCategory.TabIndex = 5;
            // 
            // cmbProperty
            // 
            cmbProperty.FormattingEnabled = true;
            cmbProperty.Location = new Point(42, 254);
            cmbProperty.Margin = new Padding(4);
            cmbProperty.Name = "cmbProperty";
            cmbProperty.Size = new Size(542, 33);
            cmbProperty.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(44, 348);
            txtDescription.Margin = new Padding(4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(540, 138);
            txtDescription.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(51, 548);
            txtAmount.Margin = new Padding(4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(533, 31);
            txtAmount.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(42, 620);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(49, 664);
            txtDate.Margin = new Padding(4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(535, 31);
            txtDate.TabIndex = 10;
            // 
            // btnSaveExpense
            // 
            btnSaveExpense.Location = new Point(56, 750);
            btnSaveExpense.Margin = new Padding(4);
            btnSaveExpense.Name = "btnSaveExpense";
            btnSaveExpense.Size = new Size(321, 85);
            btnSaveExpense.TabIndex = 11;
            btnSaveExpense.Text = "Save Expense";
            btnSaveExpense.UseVisualStyleBackColor = true;
            btnSaveExpense.Click += btnSaveExpense_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(420, 750);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 85);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 844);
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
            Margin = new Padding(4);
            Name = "AddExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpense";
            Load += AddExpense_Load;
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