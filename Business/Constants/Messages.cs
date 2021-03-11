using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarAddedInvalid = "Araba eklenemedi. Kayıt koşulları; \n" +
                    "-Arabanın model adı 2 karaktenin üzerinde olmalıdır \n" +
                    "-Arabanın günlük fiyatı sıfırdan büyük olmalıdır";
        public static string CarUpdate = "Araç güncellendi";
        public static string CarUpdateInvalid = "Araba eklenemedi. Kayıt koşulları; \n" +
                    "-Araba açıklaması en az iki karakter içermelidir.";
        public static string CarDelete = "Araç silindi";
        public static string MaintenanceTime = "Bakımda";
        public static string CarListed = "Araçlar listelendi";
    }
}
