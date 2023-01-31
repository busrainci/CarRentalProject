using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarAdded = "Araç listeye eklendi.";
        public static string ColorAdded = "Araç rengi listeye eklendi. ";
        public static string BrandAdded = "Araç markası listeye eklendi.";
        public static string CustomerAdded = "Müşteri eklenmiştir.";
        public static string UserAdded = "Kullanıcı eklendi.";


        public static string CarNotAdded = "Araç eklenmedi,lütfen araç ismini ve günlük fiyatını kontrol ediniz.";
        public static string CustomerNotAdded = "Müşteri eklenmedi.";
        public static string UserNotAdded = "Kullanıcı eklenmedi.";


        public static string CarUpdate = "Araç güncellemesi başarılı.";
        public static string ColorUpdate = "Araç rengi başarıyla güncellenmiştir.";
        public static string BrandUpdate = "Araç modeli güncellemesi başarılı";
        public static string CustomerUpdate = "Müşteri güncellendi";
        public static string UserUpdate = "Kullanıcı güncellendi.";

        public static string CarNotUpdate = "Araç güncellenmedi,lütfen araç ismini ve günlük fiyatını kontrol ediniz.";
        public static string BrantNotUpdate = "Araç model güncellemesi başarısız.";
        public static string CustomerNotUpdate = "Müşteri güncellenmedi.";
        public static string UserNotUpdate = "Kullanıcı güncellenmedi.";

        public static string CarDeleted = "Araç listeden kaldırıldı.";
        public static string ColorDeleted = "Araç rengi kaldırılmıştır.";
        public static string BrandDeleted = "Araç modeli kaldırılmıştır.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string UserDeleted = "Kullanıcı silindi.";


        public static string ColorNotDeleted = "Araç rengi kaldırılmadı.";
        public static string CarNotDeleted = "Araç listeden kaldırılmadı lütfen araç ismini ve aracın günlük fiyatını kontrol ediniz.";
        public static string BrandNotDeleted = "Araç modeli kaldırılmadı.";
        public static string CustomerNotDeleted = "Müşteri silinmedi.";
        public static string UserNotDeleted = "Kullanıcı silinmedi.";

        public static string CarsListed = "Araçlar listelendi : ";
        public static string ColorListed = "Araç renkleri listelendi :";
        public static string BrandListed = "Araç markaları listelendi :";
        public static string CustomerListed = "Müşteriler listelendi : ";
        public static string UserListed = "Kullanıcılar listelendi.";

        public static string RentalFailed = "Kiralama başarısız";
        public static string RentalSuccessful = "Kiralama başarılı";

        public static string CarNameInvalid = "Araç ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda...";
        public static string DailyPriceInvalid = "Aracın günlük fiyatı geçersiz ! ";
        public static string DailyPriceBigFromZero = "Aracın günlük fiyatı sıfırdan büyük olmalıdır.";
        public static string CarNameLengthBigFromTwo = "Araç isminin uzunluğu 2 karakterden uzun olmalıdır.";

        
    }
}
