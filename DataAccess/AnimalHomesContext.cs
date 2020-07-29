using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalHomesContext:DbContext
    {
        public AnimalHomesContext():base("Connect")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}
