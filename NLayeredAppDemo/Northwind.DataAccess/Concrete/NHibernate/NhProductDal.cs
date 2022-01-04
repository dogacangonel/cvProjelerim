using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new List<Product> {

                new Product
                {
                    ProductId=4,
                    CategoryId=5,
                    ProductName="Beevegares",
                    UnitPrice=15,
                    UnitsInStock=11,
                    QuantityPerUnit="1 box in 6 units"

                }
            }.ToList();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
