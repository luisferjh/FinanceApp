using FinanceApp.Repository.Interfaces.Actions;
using FinanceApp.Web.Models.Budgets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Budgets
{
    public interface ITypeOperationService: IReadRepository<TypeOperationVwModel, int>,
                              ICreateRepository<AddTypeOperationVwModel>,
                              IUpdateRepository<UpdateTypeOperationVwModel>,
                              IRemoveRepository<DeleteBudgetVwModel, int>
    {
    }
}
