using Mini.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Interfaces
{
    public interface IBaseDataService
    {
        Task AddAsync(BaseDataDto baseData);

        Task UpdateAsync(BaseDataDto baseData);

        Task RemoveAsync(Guid id);

        List<BaseDataDto> GetAlls();

        BaseDataDto GetByID(Guid id);
    }
}
