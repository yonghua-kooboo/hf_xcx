using Mini.Data.Entity;
using Mini.Interfaces;
using Mini.Interfaces.Interfaces;
using Mini.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Bll.Services
{
    public class UserService : IUserService
    {
        private readonly IDataProvider<User> dataProvider;

        public UserService(IDataProvider<User> dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public async Task AddAsync(UserDto model)
        {
            await dataProvider.AddAsync(new User
            {
                ActiveStatu = (Mini.Data.Entity.ActiveStatu)model.ActiveStatu
            });
        }

        public List<UserDto> GetAlls()
        {
            throw new NotImplementedException();
        }

        public UserDto GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserInfo(string userName, string password)
        {
            var user = dataProvider.GetByLamada(item => item.Name == userName && item.Password == password).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User is not exists!");
            }

            if (user.ActiveStatu == Data.Entity.ActiveStatu.InActive)
            {
                throw new Exception("User is inactive!");
            }

            return new UserDto
            {
                ID = user.ID,
                ActiveStatu = (Mini.Interfaces.Models.ActiveStatu)user.ActiveStatu
            };
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
