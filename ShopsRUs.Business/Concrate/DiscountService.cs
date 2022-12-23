
using ShopRUs.Core.Utilities.Helper;
using ShopRUs.Data.Concrate;
using ShopRUsWebAPI.Enums;
using ShopsRUs.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Business.Concrate
{
    public class DiscountService : IDiscountService
    {
        readonly DiscountHelper helper = new DiscountHelper();
        public async Task<decimal> DiscountCalculation(User user, Bill bill)
        {
            decimal totalAmount = helper.CalculateTotal(bill.items);
            decimal groceryAmount = helper.CalculateTotalPerType(bill.items, ItemType.GROCERY);
            decimal nonGroceryAmount = totalAmount - groceryAmount;
            decimal userDiscount = helper.GetUserDiscount(user);

            nonGroceryAmount = helper.CalculateDiscount(nonGroceryAmount, userDiscount);

            decimal finalAmount = groceryAmount + nonGroceryAmount;

            if (userDiscount == 0)
                finalAmount = ((groceryAmount + nonGroceryAmount) - (helper.CalculateBillsDiscount(totalAmount)));


            return await Task.FromResult(finalAmount);

        }

        public async Task<List<EnumValue>> GetEnumList<T>()
        {
            return await Task.FromResult(helper.GetEnumList<T>());
        }

    }
}
