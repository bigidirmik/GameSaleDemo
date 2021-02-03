using GameSaleDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public string DateOfBirth { get; set; }
    }
}
