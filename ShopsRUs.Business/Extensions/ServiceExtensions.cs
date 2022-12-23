
using Microsoft.Extensions.DependencyInjection;
using ShopRUs.Core.Utilities.Helper;
using ShopsRUs.Business.Abstract;
using ShopsRUs.Business.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRUs.Core.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDiscountService(this IServiceCollection services) =>
          services.AddScoped<IDiscountService, DiscountService>();
        public static void ConfigureDiscountHelper(this IServiceCollection services) =>
          services.AddScoped<IDisCountHelper, DiscountHelper>();

    }
}
