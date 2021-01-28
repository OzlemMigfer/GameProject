using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //her zaman önce soyut sınıf yani interface ni yaz sonra somut sınıfını yaz
    interface IUserValidationService//kullanıcıyı doğrulama
    {
        bool Validate(Gamer gamer);//void değil bool yazdık-true/false dönsün diye
    }
}
