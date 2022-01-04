using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Northwind.Business.Utilies;

namespace Northwind.Business.Concrete
{
    //public class ProductManager //--> Görüldüğü üzere burasıda çıplak bu yuzden burası içinde bir interface oluşturuyoruz.
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception)
            {

                throw new Exception("Ürün Silinmedi...");
            }

        }


        public List<Product> GetProducts()
        {

            return _productDal.GetAll();

        }


        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string key)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(key.ToLower()));
        }



        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
