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
        public static string CarListed = "Araçlar listelendi";
        public static string CarDelete = "Araç silindi";

        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalDelete = "Kiralama bilgisi silindi";
        public static string RentalListed = "Kiralama bilgileri listelendi";
        public static string RentalUpdate = "Kiralama Bilgisi Güncellendi";
        public static string RentalAddedError = "Araç teslim edilmediği için tekrar kiraya verilemez";
        public static string RentalUpdateReturnDate = "Araç Teslim Alındı";
        public static string RentalUpdateReturnDateError = "Araç Teslim Alınmış";

        public static string CustomerAdded = "Müsteri eklendi";
        public static string CustomerDeleted = "Müsteri silindi";
        public static string CustomerUpdated = "Müsteri güncellendi";
        public static string CustomerNameInvalid = "Müsteri ismi geçersiz";
        public static string CustomersListed = "Müşteriler listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorsListed = "Renkler listelendi";

        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandAdded = "Marka başarıyla veritabanına eklendi.";
        public static string BrandUpdate = "Marka başarıyla güncellendi.";
        public static string BrandsListed = "Markalar Listeleniyor...";
        public static string BrandDeleted = "Marka başarıyla veritabanından silindi.";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string FirstNameLastNameInvalid = "İsim veya Soyisim Girilmemiş";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserNotDeleted = "HATA. Kullanıcı Silinemedi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listeleniyor...";



        public static string MaintenanceTime = "Bakımda";
        public static string CarImagesAdded="Araba görseli eklendi";
        public static string CarImagesDeleted= "Araba görseli silindi";
        public static string CarImagesUpdate = "Araba görseli güncellendi";
        public static string CarImagesListed = "Araba görseli listelendi";
        public static string CarCheckImageLimited="";
    }
}
