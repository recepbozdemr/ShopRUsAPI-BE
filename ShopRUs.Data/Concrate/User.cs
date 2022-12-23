using ShopRUsWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Data.Concrate
{
    public class User
    {
        [Required]
        public UserType userType { get; set; }
        [Required]
        public DateTime registerDate { get; set; }
    }
}
