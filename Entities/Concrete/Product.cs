using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity // public oldugu zaman bu classa diger katmanlarda ulasabilsin demek. Bir classin defaultu internaldir ve sadece entities ulasabilir
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
