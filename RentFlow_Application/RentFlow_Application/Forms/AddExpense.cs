using RentFlow_Application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentFlow_Application.Forms
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            var categories = new List<string> { "All Categories", "Maintenance", "Insurance", "Security", "Utilities" };
            cmbExpenseCategory.DataSource = categories;


            var propNames = DataStore.Properties.Select(p => p.GetPropertyName()).ToList();
            propNames.Insert(0, "All Properties");
            cmbProperty.DataSource = propNames;
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            { MessageBox.Show("Enter description"); return; }

            if (!decimal.TryParse(txtAmount.Text, out decimal amt) || amt <= 0)
            { MessageBox.Show("Enter valid amount"); return; }

            if (!DateTime.TryParse(txtDate.Text, out DateTime dt))
            { MessageBox.Show("Enter valid date"); return; }

            var exp = new Expense()
            {
                Category = cmbExpenseCategory.Text, // if you don't have this on popup, delete this line
                Property = cmbProperty.Text,
                Description = txtDescription.Text.Trim(),
                Amount = amt,
                Date = dt.ToString("yyyy-MM-dd")
            };

            DataStore.LoadExpenses();
            DataStore.theExpenses.Add(exp);
            DataStore.SaveExpenses();

            MessageBox.Show("Saved!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
