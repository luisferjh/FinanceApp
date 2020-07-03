using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Models.Users
{
    public class UserVwModel
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int IdStatus { get; set; }
    }
}
