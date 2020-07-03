using FinanceApp.Repository.Interfaces.Actions;
using FinanceApp.Web.Models.CategoryExpenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.CategoryExpenses
{
    public interface ICategoryService:IReadRepository<CategoryVwModel, int>, 
                                      ICreateRepository<AddCategoryVwModel>, 
                                      IUpdateRepository<UpdateCategoryVwModel>,
                                      IRemoveRepository<DeleteCategoryVwModel, int>

    {

    }
}
