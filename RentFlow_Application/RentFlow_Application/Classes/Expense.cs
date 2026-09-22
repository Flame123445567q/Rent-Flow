using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RentFlow_Application.Classes
{
    public class Expense
    {
        public string Category { get; set; }
        public string Property { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }

    }
}
