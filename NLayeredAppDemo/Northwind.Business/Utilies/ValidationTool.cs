using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilies
{
    public static class ValidationTool
    {
        public static void  Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity); //--> Bu kısım önemli IValidator güvenlik açısında gireceğimiz veririnin tipini ValidationContext nesnesi ile belirtmemizi istiyor. Biz bunu burada belirttik. Eski sürümde yoktu ancak yeni sürümde mevcut 
            
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

    }
}
