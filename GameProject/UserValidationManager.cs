using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if (gamer.BirthYear == 2001 && gamer.FirstName== "Nihal" && gamer.LastName=="Kadakal"&& gamer.IdentityNumber==153)
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
