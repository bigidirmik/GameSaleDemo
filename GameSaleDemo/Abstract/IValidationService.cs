using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
