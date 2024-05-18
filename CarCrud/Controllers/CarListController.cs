using CarCrud.Models;
using CarCrud.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarCrud.Controllers
{
    public class CarListController : Controller
    {
        private readonly ICarroRepo _carroRepo;

        public CarListController(ICarroRepo carroRepo)
        {
            _carroRepo = carroRepo;
        }

        public IActionResult Index()
        {
            List<CarModel> carro = _carroRepo.GetAll();
            return View(carro);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            CarModel carro = _carroRepo.ListByID(id);
            return View(carro);
        }

        public IActionResult DeleteRequest(int id)
        {
            CarModel carro = _carroRepo.ListByID(id);
            return View(carro);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _carroRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(CarModel car)
        {
            _carroRepo.Add(car);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(CarModel car)
        {
            _carroRepo.Update(car);
            return RedirectToAction("Index");
        }
    }
}
