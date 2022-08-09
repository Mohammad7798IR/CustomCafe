using CustomDrink.Model.Entities;
using FluentValidation;

namespace CustomDrink.Common.ClassHelpers
{
    public class StoreValidations : AbstractValidator<Store>
    {
        public StoreValidations()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();

            RuleFor(x=>x.Address).NotNull().NotEmpty();
        }
    }
}
