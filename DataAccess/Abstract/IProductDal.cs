using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal //interface in operasyonlari public, public olmadigi surece kendisi public degil
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId); //urunleri category id ye gore listele.  Buraya ekledigimiz interface i classlarda da implemente etmemiz gerekiyor

    }
}
