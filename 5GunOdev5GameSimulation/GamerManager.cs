using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev5GameSimulation
{
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }


        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " kayıt oldu!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " kayıt silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " kayıt güncellendi!");
        }
    }
}
