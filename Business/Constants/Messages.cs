using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages  //static yapınca newlemene gerek kalmıyor.
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Girdğiniz isimde bir ürün zaten var";
        public static string MaxCategoryError = "Maksimum kategori sayısına ulaşıldı.";
    }
}
