﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    //Bu yapıda Windows Form direk Contanier oluşturucu olmadığı için biz kendimiz bir Kernel yazdık. Bu sayede IOC işlemini gerçekleştirmiş olacağız.
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
