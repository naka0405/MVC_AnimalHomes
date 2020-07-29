using AnimalHomes.Models;
using AutoMapper;
using BuisnessLogic;
using BuisnessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnimalHomes.Controllers
{
    public class TestController : ApiController
    {
        private readonly Mapper _mapper;
        private readonly AnimalManager _animalManager;

        public TestController()
        {
           _animalManager = new AnimalManager();

            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<AnimalModel, AnimalViewModel>();
                x.CreateMap<HouseModel, HouseViewModel>();
            });
            _mapper = new Mapper(config);
        }
        // GET: api/Test
        public IEnumerable<AnimalViewModel> Get()
        {
            var allAnimalsModel = _animalManager.GetAllAnimals();
            var allAnimalsView = _mapper.Map<List<AnimalViewModel>>(allAnimalsModel);
            return allAnimalsView;
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
