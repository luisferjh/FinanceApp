using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Repository.Interfaces.Actions
{
    public interface ICreateRepository<T> where T: class
    {
        Task<int> AddAsync(T model);
    }
}
