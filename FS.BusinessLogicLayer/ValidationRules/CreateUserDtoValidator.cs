using FluentValidation;
using FS.BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.ValidationRules
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required");

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email is incorrect format");

            RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("First Name is required");

            RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last Name is required");

            RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required");
        }
    }
}
