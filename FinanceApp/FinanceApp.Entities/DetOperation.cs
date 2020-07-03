using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class DetOperation
    {
        public int IdUser { get; set; }
        public int IdOperation { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Operation Operation { get; set; }
    }
}
