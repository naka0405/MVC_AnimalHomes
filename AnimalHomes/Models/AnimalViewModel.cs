using BuisnessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalHomes.Models
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int HouseId { get; set; }
        public HouseViewModel AnimalHouse { get; set; }
    }
}