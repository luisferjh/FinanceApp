using AutoMapper;
using FinanceApp.Entities;
using FinanceApp.Web.Models.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.MappingDTOs
{
    public class ExpenseProfile:Profile
    {
        public ExpenseProfile()
        {
            CreateMap<AddExpenseViewModel,Expense>();           
        }
    }
}
