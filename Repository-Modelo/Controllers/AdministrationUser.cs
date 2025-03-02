using Microsoft.AspNetCore.Mvc;
using Repository_Modelo.Models;

namespace Repository_Modelo.Controllers
{
    public class AdministrationUser : Controller
    {

        private readonly IUsuarios _usuarios;

        public AdministrationUser(IUsuarios usuarios)
        {
            _usuarios = usuarios;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(Users user)
        {
            if (ModelState.IsValid)
            {
                await _usuarios.Create(user);
                Console.WriteLine("Registrado con exito!!");
                return RedirectToAction("Index", "MostrarUsuarios");
            }

            return RedirectToAction("Index", "NuevoUsuario");
        }

        public async Task<IActionResult> Update(Users user)
        {
            if (ModelState.IsValid)
            {
                var response = await _usuarios.Actualizar(user);
                Console.WriteLine(response);
                if (response)
                {
                    return RedirectToAction("Index", "MostrarUsuarios");
                }
            }
            return RedirectToAction("Index", "NuevoUsuario");
        }

        public async Task<IActionResult> Delete(int id)
        {
            Console.WriteLine(id);
            var response = await _usuarios.DeleteById(id);
            if (response) { return RedirectToAction("Index", "MostrarUsuarios"); }

            return RedirectToAction("Index", "NuevoUsuario");

        }
    }
}
