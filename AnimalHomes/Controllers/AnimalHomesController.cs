using AnimalHomes.Models;
using AutoMapper;
using BuisnessLogic;
using BuisnessLogic.Managers;
using BuisnessLogic.Models;
using DataAccess.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AnimalHomes.Controllers
{
        public class AnimalHomesController : Controller
    {
        private readonly HouseManager _houseManager;
        private readonly AnimalManager _animalManager;

        private readonly Mapper _mapper;

        public AnimalHomesController()
        {
            _houseManager = new HouseManager();
            _animalManager = new AnimalManager();

            var config = new MapperConfiguration(x =>
              {
                  x.CreateMap<AnimalModel, AnimalViewModel>();
                  x.CreateMap<AnimalModel, GeneralModel>();
                  x.CreateMap<HouseModel, HouseViewModel>();
                  x.CreateMap<HouseModel, GeneralModel>();
              });
            _mapper = new Mapper(config);
        }

        // GET: AnimalHomes
        public async Task<ActionResult> Index()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var createUser = await userManager.CreateAsync(new Employee
            {
                LastName = "Julia",
                Email = "Julia@gmail.com",
                UserName = "Juli",
                BirthDate=new DateTime(1985,25,07)
            }, "123456789");
            return View();
        }

        public ActionResult GetAllAnimals()
        {
            var allAnimalsModel=_animalManager.GetAllAnimals();
            var allAnimalsView =_mapper.Map<List<AnimalModel>,List<AnimalViewModel>>(allAnimalsModel);
            var newViewModel= new GetAllAnimalViewModel();
            newViewModel.Animals = allAnimalsView;
            return View(newViewModel);
        }

        public ActionResult GetAllHouses()
        {
            var allHousesModel = _houseManager.GetAllHouses();
            var allHousesView = _mapper.Map<List<HouseModel>, List<HouseViewModel>>(allHousesModel);
            var newViewModel = new GetAllHousesViewModel();
            newViewModel.Houses = allHousesView;
            return View(newViewModel);
        }

        public ActionResult GetGeneralPartialView()
        {
            var allAnimalsModel = _animalManager.GetAllAnimals();
            var allAnimalsView = _mapper.Map<List<GeneralModel>>(allAnimalsModel);

            var newViewModel = new GetAllGeneralModel();
            newViewModel.ListGeneralModels = allAnimalsView;
            return PartialView(newViewModel);

        }

        public ActionResult GetHousesPartialView()
        {           
            var allHousesModel = _houseManager.GetAllHouses();
            var allHousesView = _mapper.Map<List<GeneralModel>>(allHousesModel);
            var newViewModel = new GetAllGeneralModel();
            newViewModel.ListGeneralModels = allHousesView;
            return PartialView("GetGeneralPartialView", newViewModel);
        }

    }
}