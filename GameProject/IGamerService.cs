using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService//operasyonları buraya tanimlicaz-soyut sınıf
    {
        void Add(Gamer gamer);//gamer yazmayı unutma-önemli
        void Update(Gamer gamer);
        void Remove(Gamer gamer);
    }
}
