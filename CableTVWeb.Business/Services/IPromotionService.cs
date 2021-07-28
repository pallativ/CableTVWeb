using CableTV.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public interface IPromotionService
    {
        Task<IEnumerable<Promotion>> GetAll();
        Task<IEnumerable<Promotion>> GetBy(bool isActive);
        Task<Promotion> Add(Promotion promotion);
        Task<Promotion> Delete(int promotionId);
    }
}