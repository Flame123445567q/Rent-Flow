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
    }
}
