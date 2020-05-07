using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Models.Expenses
{
    public class AddExpenseViewModel
    {
        //[Required]
        //public int IdCategoryExpense { get; set; }
        [Required]
        [StringLength(70)]
        public string DescriptionExpense { get; set; }
        [Required]
        public DateTime DateExpense { get; set; }
        [Required]
        public decimal AmountSpent { get; set; }
        [Required]
        public int IdStatus { get; set; }
    }
}
