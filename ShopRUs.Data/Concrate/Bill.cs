using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Data.Concrate
{
    public class Bill
    {
        [Required]
        public List<Item> items { get; set; }
    }
}
