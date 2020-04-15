using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class CategoryExpense
    {
        public int IdCategoryExpense { get; set; }
        public string CodCategoryExpense { get; set; }
        public string DescriptionCategoryExpense { get; set; }
        public int IdStatus { get; set; }
    }
}
