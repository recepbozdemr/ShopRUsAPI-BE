using ShopRUs.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Data.Dtos
{
    public class DiscountRequest
    {
        public User user { get; set; }
        public Bill bill { get; set; }
    }
}
