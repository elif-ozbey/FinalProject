using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccsess
{
    public interface IEntityRepository <T> where T:class,IEntity, new() //class demek referans tipi olabilir. Sadece class yazarsak tum classlari yazabiliriz ancak biz sadece kendi classlarimiz gelsin istiyoruz bu nedenle IEntity i buraya tanimliyoruz. IEntitiy nin kendisinin gelmesini istemedigimiz icin new ekliyoruz.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre yoksa tum data gelir
        T Get(Expression<Func<T, bool>> filter); //Datanin hepsini degil filtreye gore gelmesini saglamak istiyoruz. Filtre burda zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
