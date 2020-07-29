using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalHomes.Models
{
    public class GetAllHousesViewModel
    {
        public IList<HouseViewModel> Houses { get; set; }
    }
}