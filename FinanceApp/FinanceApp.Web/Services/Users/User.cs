using FinanceApp.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Users
{
    public class User : IUser
    {
        public Task<IEnumerable<UserVwModel>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(AddUserVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DeleteUserVwModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IEnumerable<DeleteUserVwModel> t)
        {
            throw new NotImplementedException();
        }

        public Task<UserVwModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(UpdateUserVwModel model)
        {
            throw new NotImplementedException();
        }
    }
}
