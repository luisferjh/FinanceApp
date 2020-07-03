using FinanceApp.Web.Models.Budgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Budgets
{
    public class TypeOperationService : ITypeOperationService
    {
        public Task<int> AddAsync(AddTypeOperationVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DeleteBudgetVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<DeleteBudgetVwModel> t)
        {
            throw new NotImplementedException();
        }

        public Task<TypeOperationVwModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeOperationVwModel>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(UpdateTypeOperationVwModel model)
        {
            throw new NotImplementedException();
        }
    }
}
