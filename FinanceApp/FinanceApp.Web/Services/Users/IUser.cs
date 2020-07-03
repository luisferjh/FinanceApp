using FinanceApp.Repository.Interfaces.Actions;
using FinanceApp.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Users
{
    public interface IUser: IReadRepository<UserVwModel, int>,
                            ICreateRepository<AddUserVwModel>,
                            IUpdateRepository<UpdateUserVwModel>,
                            IRemoveRepository<DeleteUserVwModel, int>
    {
    }
}
