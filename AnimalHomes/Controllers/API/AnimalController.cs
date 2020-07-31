using AnimalHomes.Models;
using AutoMapper;
using BuisnessLogic;
using BuisnessLogic.Managers;
using BuisnessLogic.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace AnimalHomes.Controllers.API
{
    public class AnimalController : ApiController
    {
        private readonly Mapper _mapper;
        private readonly AnimalManager _animalManager;

        public AnimalController()
        {
           
            _animalManager = new AnimalManager();

            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<AnimalModel, Models.AnimalViewModel>();               
            });
            _mapper = new Mapper(config);
        }


        // GET: api/Animal/5
        public string Get()
        {            
            var allAnimalsModel = _animalManager.GetAllAnimals();
            var allAnimalsView = _mapper.Map<List<AnimalViewModel>>(allAnimalsModel);
            //AnimalViewModel animalViewModel;
            string result="";
            //foreach (var item in allAnimalsView)
            //{
             
                 result = JsonConvert.SerializeObject(allAnimalsView);
           // }

            return result;
        }

        //// GET: api/Animal
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// POST: api/Animal
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Animal/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Animal/5
        //public void Delete(int id)
        //{
        //}
    }
}
