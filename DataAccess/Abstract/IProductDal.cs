﻿using Core.DataAccsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product> //interface in operasyonlari public, public olmadigi surece kendisi public degil
    {
       

    }
}
