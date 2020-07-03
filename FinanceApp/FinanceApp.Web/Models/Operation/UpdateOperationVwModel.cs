using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Models.Expenses
{
    public class UpdateOperationVwModel
    {
        [Required]
        public int IdOperation { get; set; }
        [Required]
        public int IdTypeOperation { get; set; }
        [Required]
        public string CodeTypeOperation { get; set; }
        [Required]
        public DateTime OperationDate { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
