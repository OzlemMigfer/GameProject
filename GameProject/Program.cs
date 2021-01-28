using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni bir e-devlet sistemi kulanılmak istense önce class oluşturyoruz ve IUserValidation dan implemente ederek,doğrulama servisi yerine de yazarak yapabiliyoruz
            GamerManager gamerManager = new GamerManager(new UserValidationManager());//doğrulama servisini de girmek gerek
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                NationalityId = 3333333,
                FirstName = "ÖZLEM",
                LastName = "MİĞFER"
            });

            Console.WriteLine("\n");

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.PressScreen(new Campaign{ });
        } 
    }
}
