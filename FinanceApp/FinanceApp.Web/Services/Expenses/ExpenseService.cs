using AutoMapper;
using FinanceApp.Data;
using FinanceApp.Entities;
using FinanceApp.Web.Models.Expenses;
//using FinanceApp.Web.Services.Expenses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Expenses
{
    public class ExpenseService : IExpenseService
    {
        private readonly DbContextFinance _context;
        private readonly IMapper _mapper;
        public ExpenseService(DbContextFinance context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAsync(AddExpenseViewModel model)
        {
            //Expense exp = new Expense {
            //   AmountSpent = model.AmountSpent,
            //   DateExpense = model.DateExpense,
            //   DescriptionExpense = model.DescriptionExpense,
            //   IdStatus = model.IdStatus                

            //};

            Expense exp = _mapper.Map<Expense>(model);
            await _context.Expenses.AddAsync(exp);
            
        }

        public Task<ExpenseViewModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ExpenseViewModel>> ListAsync()
        {
            List<Expense> list = await _context.Expenses.ToListAsync();

            return list.Select(s => new ExpenseViewModel {
                IdExpense = s.IdExpense,
                //IdCategoryExpense
                IdStatus = s.IdStatus,
                DescriptionExpense = s.DescriptionExpense,
                AmountSpent = s.AmountSpent,
                DateExpense = s.DateExpense
            });
            
        }
        
     

    }
}
