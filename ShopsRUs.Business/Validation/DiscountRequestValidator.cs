using FluentValidation;
using ShopRUs.Data.Concrate;
using ShopRUs.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Business.Validation
{
    public class DiscountRequestValidator : AbstractValidator<DiscountRequest>
    {
        public DiscountRequestValidator()
        {
            //User not empty
            RuleFor(c => c.user).NotEmpty().WithMessage("Please do not leave the user type blank.");
            //User type not empty and defined user in system
            RuleFor(c => c.user.userType).NotEmpty().WithMessage("Please do not leave the user type blank.").IsInEnum().WithMessage("Please enter a defined user type.");
            //User register date not empty and must valid date
            RuleFor(c => c.user.registerDate).NotEmpty().WithMessage("Please do not leave the registration date blank.").LessThanOrEqualTo(DateTime.Now).WithMessage("Please enter a valid registration date.");
            //Bill not empty
            RuleFor(c => c.bill).NotEmpty().WithMessage("Please do not leave the bill infromation blank.");
            //Bill items not empty
            RuleFor(c => c.bill.items).NotEmpty().WithMessage("Please do not leave the bill infromation blank.");
            //Bill items count must greater tahan 0
            RuleFor(c => c.bill.items.Count).GreaterThan(0).WithMessage("Please do not leave the bill infromation blank.");
            //Bill items detail validation
            RuleForEach(c => c.bill.items).SetValidator(new BillDetailValidator());

        }
        public class BillDetailValidator : AbstractValidator<Item>
        {
            public BillDetailValidator()
            {
                //Item type must be defined and not empty
                RuleFor(c => c.itemType).NotEmpty().WithMessage("Please do not leave the items type blank.").IsInEnum().WithMessage("Please enter a defined item type.");
                //Item price not empty and greater than 0
                RuleFor(c => c.Price).NotEmpty().WithMessage("Please do not leave the items price blank.").GreaterThan(0).WithMessage("Please enter a valid price.");
            }
        }
    }
}
