using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService//somut sınıf
    {
        public bool Validate(Gamer gamer)//burayı da bool haline çevirmeyi unutma
        {
            if(gamer.Id==1 && gamer.NationalityId==3333333 && gamer.FirstName=="ÖZLEM" && gamer.LastName=="MİĞFER" && gamer.BirthYear == 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
