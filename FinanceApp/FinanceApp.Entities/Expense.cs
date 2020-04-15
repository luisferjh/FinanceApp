using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class Expense
    {
        public int IdExpense { get; set; }
       // public int IdCategoryExpense { get; set; }
        public string DescriptionExpense { get; set; }
        public DateTime DateExpense { get; set; }
        public decimal AmountSpent { get; set; }
        public int IdStatus { get; set; }
    }
}
