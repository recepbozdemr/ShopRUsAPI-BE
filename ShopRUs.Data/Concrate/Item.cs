using ShopRUsWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Data.Concrate
{
    public class Item
    {
        [Required]
        public ItemType itemType { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
