﻿using FluentValidation;

namespace CustomTextFieldValidation
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(50).WithMessage("First Name cannot exceed 50 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MaximumLength(50).WithMessage("Last Name cannot exceed 50 characters.");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Status is required.")
                .MaximumLength(20).WithMessage("Status cannot exceed 20 characters.");

            RuleFor(x => x.Age).InclusiveBetween(18, 120);
            RuleFor(x => x.DateOfBirth).NotEmpty().Must(BeAValidDate).WithMessage("Invalid date of birth");


        }
        private bool BeAValidDate(DateTime? date)
        {
            // Replace this with your custom date validation logic
            return date < DateTime.Now;
        }
    }
}
