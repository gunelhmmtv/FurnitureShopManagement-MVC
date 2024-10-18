using FluentValidation;
using FS.BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.ValidationRules
{
    public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductDtoValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty()
                .WithMessage("Name is required")
                .MinimumLength(3)
                .WithMessage("Name must be greater than 3 characters");

            RuleFor(x => x.Price)
                .NotNull()
                .WithMessage("Price is required")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Price must be a positive value")
                .LessThanOrEqualTo(1000)
                .WithMessage("Price must be less than or equal to 1000");
            RuleFor(x => x.InStock)
                .NotNull().WithMessage("In Stock status is required");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0)
                .WithMessage("Category is required");
        }
    }
}
