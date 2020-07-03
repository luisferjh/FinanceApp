using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Icono { get; set; }
        public bool Status { get; set; }

        public ICollection<TypeOperation> TypeOperations { get; set; }
    }
}
