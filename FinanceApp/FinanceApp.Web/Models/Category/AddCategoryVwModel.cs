using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Models.CategoryExpenses
{
    public class AddCategoryVwModel
    {       
        public string Code { get; set; }
        public string Description { get; set; }
        public string Icono { get; set; }
        public bool Status { get; set; }
    }
}

