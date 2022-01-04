using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal { get; set; }
        public CategoryManager(ICategoryDal category)
        {
            _categoryDal = category;
        }
        public List<Category> GetCategories()
        {
            return _categoryDal.GetAll();
        }
    }
}
