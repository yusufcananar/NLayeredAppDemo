﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Entities.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
