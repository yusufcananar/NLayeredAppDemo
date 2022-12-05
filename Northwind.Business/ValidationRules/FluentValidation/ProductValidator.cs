using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Null check
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product Name cannot be empty!");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category cannot be empty!");
            RuleFor(p =>p.UnitPrice).NotEmpty().WithMessage("Unit Price cannot be empty!");
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p =>p.UnitPrice).LessThan(100).When(p => p.CategoryId == 2).WithMessage("UnitPrice for selected Category cannot be greater than 100 !");

            RuleFor(p => p.ProductName).Must(StartsWithA).WithMessage("Product Name must start with A");
        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
