using AutoMapper;
using BuisnessLogic.Models;
using DataAccess.Models;
using DataAccess.Repozitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class AnimalManager
    {
        private readonly AnimalRepozitoriy _animalRepoz;
        public readonly Mapper _mapper;

        public AnimalManager()
        {
            _animalRepoz = new AnimalRepozitoriy();           

            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Animal, AnimalModel>();
                x.CreateMap<AnimalModel, Animal>();
                x.CreateMap<House, HouseModel>();
            });
            _mapper = new Mapper(config);
        }

        public List<AnimalModel> GetAllAnimals()
        {           
           var allAnimals= _animalRepoz.GetAllAnimals();
           var allAnimalsModel = _mapper.Map<IEnumerable<Animal>,List<AnimalModel>>(allAnimals);
           return allAnimalsModel;
        }
    }
}
