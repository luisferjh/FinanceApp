using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class TypeOperation
    {
        public int IdTypeOperation { get; set; }
        public int IdCategory { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Icono { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        // Navigation Properties
        public Category Category { get; set; }
        public ICollection<Operation> Operations { get; set; }


    }
}
