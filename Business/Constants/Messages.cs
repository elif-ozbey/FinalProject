using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";

        public static string MaintenanceTime = "Sistem Bakimda";
        public static string ProductsListed = "Urunler listelendi";

        public static string ProductCountCategoryEror = "Bir kategoride en fazla 10 urun olabilir";

        public static string ProductNameAlreadyExists = "Bu urun adinda farkli bir urun mevcut";

        public static string CategoryLimitExceded = "Kategori limiti asildigi icin urun eklenemiyor";
    }
}
