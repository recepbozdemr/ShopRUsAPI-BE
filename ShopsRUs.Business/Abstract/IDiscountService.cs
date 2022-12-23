using ShopRUs.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Business.Abstract
{
    public interface IDiscountService
    {
        Task<decimal> DiscountCalculation(User user, Bill bill);

        Task<List<EnumValue>> GetEnumList<T>();
    }
}
