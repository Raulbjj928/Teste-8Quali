using Microsoft.AspNetCore.Mvc;
using Test8Quali.Models;
using Test8Quali.Servicos.Interfaces;

namespace Test8Quali.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            var clientes = _clienteService.GetAll();
            return View(clientes);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            var cliente = _clienteService.GetById(id);

            return View(cliente);
        }
        public IActionResult Delete(int id)
        {
            var cliente = _clienteService.GetById(id);

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Create(ClienteModel cliente)
        {
            _clienteService.Add(cliente);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel cliente)
        {
            _clienteService.Update(cliente);

            return RedirectToAction("Index");
        }

        
        public IActionResult Excluir(int id)
        {
            _clienteService.Delete(id);

            return RedirectToAction("Index");
        }

    }
}
