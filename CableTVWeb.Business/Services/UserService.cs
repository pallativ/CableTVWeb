using CableTV.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public class UserService : IUserService
    {
        public Task<IEnumerable<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

    }
}
