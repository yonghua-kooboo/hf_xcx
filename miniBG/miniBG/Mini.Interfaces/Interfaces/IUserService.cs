using Mini.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Interfaces.Interfaces
{
    public interface IUserService : IServiceBase<UserDto>
    {
        UserDto GetUserInfo(string userName, string password);
    }
}
