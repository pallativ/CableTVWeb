using CableTV.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetByUserId(string userId);
        Task<User> GetByMobile(string mobile);
    }
}