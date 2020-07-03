using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Models.Budgets
{
    public class TypeOperationVwModel
    {
        [Required]
        public int IdTypeOperation { get; set; }
        [Required]
        public int IdCategory { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icono { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
