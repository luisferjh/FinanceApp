using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int IdStatus { get; set; }

        // Navigation Properties
        public ICollection<DetOperation> DetOperations { get; set; }
    }
}
