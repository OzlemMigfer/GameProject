using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //somut sınıf açtık
    //bir manager sınıfın içerisinde başka bir manager sınıf kullanacaksak bunu constructor ile yapıyoruz
    class GamerManager : IGamerService//interface i implemente ettik-hiçbir sınıfı çıplak bırakma
    {
        //Bu sistem daha iyi mernisten çünkü mernis değil de başka servise geçilirse o zaman burda rahatlıkla kullanabileceğiz
        IUserValidationService _userValidationService;//constructor çağırdık-bir aşağıdaki eklenmiş oldu
        public GamerManager(IUserValidationService userValidationService)//doğrulama servisi kullanmış olduk
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Eklendi.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız.\nKullanıcı Bulunamadı!");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
