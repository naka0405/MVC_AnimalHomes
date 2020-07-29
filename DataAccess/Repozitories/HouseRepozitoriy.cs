using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataAccess.Repozitories
{
    public class HouseRepozitoriy
    {
        public List<House> GetAllHouses()
        {
            using (var ctx = new AnimalHomesContext())
            {
                List<House> allHouses = ctx.Houses.Include(x => x.Animals).ToList();
                ctx.SaveChanges();
                return allHouses;
            }
            
        }
    }
}
