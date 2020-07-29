using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Initializer:DropCreateDatabaseIfModelChanges<AnimalHomesContext>
    {
        protected override void Seed(AnimalHomesContext context)
        {
            var hole = new House() { Name = "Hole" };
            var rabbit1 = new Animal() { Name = "Rabbit1", Age = 3, AnimalHouse = hole };
            var rabbit2 = new Animal() { Name = "Rabbit2", Age = 3, AnimalHouse = hole };
            var den = new House() { Name = "Den" };
            var bear= new Animal() { Name = "Bear", Age = 7, AnimalHouse =den  };
            context.Animals.AddRange(new List<Animal>() { rabbit1, rabbit2, bear });
            context.Houses.AddRange(new List<House>() { hole, den });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
