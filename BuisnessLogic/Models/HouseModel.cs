using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.Models
{
    public class HouseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AnimalModel> Animals { get; set; }
        public HouseModel()
        {
           Animals = new List<AnimalModel>();
        }
    }
}
