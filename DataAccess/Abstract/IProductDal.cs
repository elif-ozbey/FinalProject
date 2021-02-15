using Core.DataAccsess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product> //interface in operasyonlari public, public olmadigi surece kendisi public degil
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
