using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule //Ninject Modulu  kullanılmak için inherit edildi.
    {
        public override void Load() // Servisleri kullanmak için Bind işlemi kullanılarak bize istediğimiz soyut işlemleri somut işlemlere bağladı.
        {
            //InSingletonScope bunun aynısı başla yerde üretilmesin biz performans olarak kazanıyoruz anlamına gelmektedir. 
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope(); 


        }
    }
}
