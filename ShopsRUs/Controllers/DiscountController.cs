using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopRUs.Data.Concrate;
using ShopRUs.Data.Dtos;
using ShopRUsWebAPI.Enums;
using ShopsRUs.Business.Abstract;

namespace ShopsRUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
 
        [HttpGet]
        [Route("/GetUserType")]
        public async Task<List<EnumValue>> GetUserType()
        {
            return await _discountService.GetEnumList<UserType>();
        }

        
        [HttpGet]
        [Route("/GetItemType")]
        public async Task<List<EnumValue>> GetItemType()
        {
            return await _discountService.GetEnumList<ItemType>();
        }

        [HttpPost]
        [Route("/CreateDiscount")]
        public async Task<decimal> CreateDiscount([FromBody] DiscountRequest request)
        {
            return await _discountService.DiscountCalculation(request.user, request.bill);
        }



    }
}
