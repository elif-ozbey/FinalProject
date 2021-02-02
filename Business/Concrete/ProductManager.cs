using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; 
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //Is kodlari

            // is kodlarindan geciyorsa veri erisimini cagirmam lazim. Bir is sinifi baska siniflari newlemez
            return _productDal.GetAll();
           
        }
    }
}
