using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class SteamGamerManager:BaseGamerManager
    {
        IValidationService _validationService;
        public SteamGamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public override void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Hatalı bilgi girişi!");
            }
        }
        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }
        public override void Update(Gamer gamer)
        {
            base.Update(gamer);
        }
    }
}
