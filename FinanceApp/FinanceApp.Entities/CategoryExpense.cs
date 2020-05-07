using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class CategoryExpense
    {
        //public CategoryExpense()
        //{
        //    Expenses = new HashSet<Expense>();
        //}
        public int IdCategoryExpense { get; set; }
        public string CodCategoryExpense { get; set; }
        public string DescriptionCategoryExpense { get; set; }
        public int IdStatus { get; set; }

        //Navigation Propierties

        public ICollection<Expense> Expenses { get; set; }
    }
}
