using FluentValidation;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Geçilemez");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category İsmi Boş Geçilemez");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat Boş Geçilemez");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stok Miktarı Boş Geçilemez");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim Başına Ürün Boş Geçilemez");

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(20).When(p => p.CategoryId == 3);
            //Must Bize kendi Validation oluşturmamızı sağlamaktadır.
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A ile Başlamak Zorunda");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
