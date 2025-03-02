using Microsoft.AspNetCore.Mvc;
using Repository_Modelo.Models;

namespace Repository_Modelo.Controllers
{
    public class MostrarUsuarios : Controller
    {
        private readonly IUsuarios _usuarios;

        public MostrarUsuarios(IUsuarios usuarios)
        {
            _usuarios = usuarios;
        }

        public async Task<IActionResult> Index()
        {
            var s = await _usuarios.Get();
            return View(s);
        }
    }
}
