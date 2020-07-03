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
    public class OperationService : IOperationService
    {
        private readonly DbContextFinance _context;
        private readonly IMapper _mapper;
        public OperationService(DbContextFinance context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> AddAsync(AddOperationVwModel model)
        {
            //Expense exp = new Expense {
            //   AmountSpent = model.AmountSpent,
            //   DateExpense = model.DateExpense,
            //   DescriptionExpense = model.DescriptionExpense,
            //   IdStatus = model.IdStatus                

            //};

            Operation ope = _mapper.Map<Operation>(model);
            await _context.Operations.AddAsync(ope);
            return ope.IdOperation;
        }

        public Task<int> UpdateAsync(UpdateOperationVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DeleteOperationVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<DeleteOperationVwModel> t)
        {
            throw new NotImplementedException();
        }

        public Task<OperationViewModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OperationViewModel>> ListAsync()
        {
            List<Operation> list = await _context.Operations.ToListAsync();

            return list.Select(s => new OperationViewModel {
                IdOperation = s.IdOperation,
                IdTypeOperation = s.IdTypeOperation,              
                CodeTypeOperation = s.CodeTypeOperation,
                OperationDate = s.OperationDate,
                Description = s.Description,
                Amount = s.Amount,
                Status = s.Status
            });
            
        }

     
    }
}
