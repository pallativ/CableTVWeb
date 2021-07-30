using CableTV.Db;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public class PromotionService : IPromotionService
    {
        public Task<Promotion> Add(Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public Task<Promotion> Delete(int promotionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Promotion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Promotion>> GetBy(bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
