using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == "1993" && gamer.Name == "Bilal" && gamer.Surname == "Dırmık" && gamer.NationalityId == "12345678901")
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
