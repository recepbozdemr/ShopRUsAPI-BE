using Newtonsoft.Json;
using ShopRUs.Data.Dtos;
using ShopRUsWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.UnitTest
{
    public class FakeDataTest
    {
        public static StringContent SuccessCreateDiscountData()
        {
            return new StringContent(JsonConvert.SerializeObject(LoadSuccessData()).ToString(), Encoding.UTF8, "application/json");
        }

        public static StringContent ErrorCreateDiscountData()
        {
            return new StringContent(JsonConvert.SerializeObject(LoadErrorData()).ToString(), Encoding.UTF8, "application/json");
        }


        public static DiscountRequest LoadSuccessData()
        {
            return new DiscountRequest
            {
                user = new ShopRUs.Data.Concrate.User
                {
                    registerDate = DateTime.Now,
                    userType = UserType.CUSTOMER
                },
                bill = new ShopRUs.Data.Concrate.Bill
                {
                    items = new System.Collections.Generic.List<ShopRUs.Data.Concrate.Item>()
                    { new ShopRUs.Data.Concrate.Item() { itemType = ItemType.TECHNOLOGY,Price = 100} }

                }
            };
        }
        public static DiscountRequest LoadErrorData()
        {
            return new DiscountRequest
            {
                user = new ShopRUs.Data.Concrate.User
                {
                    registerDate = DateTime.Now.AddYears(5),
                    userType = UserType.CUSTOMER
                },
                bill = new ShopRUs.Data.Concrate.Bill
                {
                    items = new System.Collections.Generic.List<ShopRUs.Data.Concrate.Item>()
                    { new ShopRUs.Data.Concrate.Item() { itemType = ItemType.TECHNOLOGY,Price = 100} }

                }
            };
        }
    }
}
