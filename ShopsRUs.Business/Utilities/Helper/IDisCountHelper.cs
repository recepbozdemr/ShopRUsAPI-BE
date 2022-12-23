using ShopRUs.Data.Concrate;
using ShopRUsWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Core.Utilities.Helper
{
    public interface IDisCountHelper
    {
        decimal CalculateTotal(List<Item> items);
        decimal CalculateTotalPerType(List<Item> items, ItemType type);
        decimal GetUserDiscount(User user);
        decimal CalculateBillsDiscount(decimal totalAmount);
        decimal CalculateDiscount(decimal amount, decimal discount);
        List<EnumValue> GetEnumList<T>();
    }
}
