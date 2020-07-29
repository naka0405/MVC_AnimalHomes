using AutoMapper;
using BuisnessLogic.Models;
using DataAccess.Models;
using DataAccess.Repozitories;
using System;
using System.Collections.Generic;


namespace BuisnessLogic
{
    public class HouseManager
    {
        private readonly HouseRepozitoriy _houseRepoz;

        public readonly Mapper _mapper;

        public HouseManager()
        {           
            _houseRepoz = new HouseRepozitoriy();

            var config = new MapperConfiguration(x =>
              {                 
                  x.CreateMap<House, HouseModel>();
                  x.CreateMap<Animal, AnimalModel>();
              });
            _mapper = new Mapper(config);
        }

        public List<HouseModel> GetAllHouses()
        {
            List<House> allHouses = _houseRepoz.GetAllHouses();
            List<HouseModel> allHousesModel = _mapper.Map<List<House>, List<HouseModel>>(allHouses);

            return allHousesModel;
        }
    }
}
