using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
