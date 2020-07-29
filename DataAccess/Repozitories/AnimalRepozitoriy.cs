using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Repozitories
{
    public class AnimalRepozitoriy
    {        
        public List<Animal> GetAllAnimals()
        {
            using(var ctx=new AnimalHomesContext())
            {
                List<Animal> allAnimals=ctx.Animals.Include(x => x.AnimalHouse).ToList();
                ctx.SaveChanges();
                return allAnimals;
            }
        }
    }
}
