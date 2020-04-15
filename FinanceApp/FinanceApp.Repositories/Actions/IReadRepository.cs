using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Repository.Interfaces.Actions
{
    public interface IReadRepository<T, Y> where T: class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> GetAsync(Y id);
    }
}
