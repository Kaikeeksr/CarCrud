using CarCrud.Models;
using CarCrud.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            try
            {
               bool deleted =  _carroRepo.Delete(id);

                if (deleted)
                {
                    TempData["MensagemSucesso"] = "Registro exclúido com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não foi possível excluir o registro :/";
                }
                return RedirectToAction("Index");
            } 
            catch(System.Exception error) 
            {
                TempData["MensagemErro"] = $"Ops, não foi possível e o carro :/ \n erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

        //MÉTODOS
        [HttpPost]
        public IActionResult Create(CarModel car)
        {
            //Impedindo que uma requisição vazia seja enviada
            try
            {
                if (ModelState.IsValid)
                {
                    _carroRepo.Add(car);
                    TempData["MensagemSucesso"] = "Registro cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(car);
            }
            catch (System.Exception error)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar o carro :/ \n erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Update(CarModel car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _carroRepo.Update(car);
                    TempData["MensagemSucesso"] = "Carro alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(car);
            }
            catch(System.Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não foi possível atualizar registro :/ \n erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
