using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev5GameSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Kadir" && gamer.LastName == "Sarıaslan" && gamer.BirthYear == 1988 && gamer.IdentityNumber == "123654789")
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
