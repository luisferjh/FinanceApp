using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class Operation
    {
        public int IdOperation { get; set; }
        public int IdTypeOperation { get; set; }
        public string CodeTypeOperation { get; set; }      
        public DateTime OperationDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }

        //Navigation Properties
        public ICollection<DetOperation> DetOperations { get; set; }
        public TypeOperation TypeOperation { get; set; }      
    
    }
}
