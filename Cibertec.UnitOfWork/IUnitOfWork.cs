﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cibertec.Repositories.Northwind;

namespace Cibertec.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
    }
}
