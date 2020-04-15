using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Entities
{
    public class Budget
    {
        public int IdBudget { get; set; }
        public int IdUser { get; set; }
        public string DescriptionBudget { get; set; }
        public decimal Balance { get; set; }
        public decimal BalanceSpent { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int RemainDays { get; set; }
        public int IdStatus { get; set; }
    }
}
