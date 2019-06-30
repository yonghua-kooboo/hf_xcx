using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Interfaces.Interfaces
{
    public interface IServiceBase<T>
    {
        Task AddAsync(T model);

        Task UpdateAsync(T model);

        Task RemoveAsync(Guid id);

        List<T> GetAlls();

        T GetByID(Guid id);
    }
}
