using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //ciplak class kalmasin' egerki bir klas inheritance yada interface almiyorsa 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
