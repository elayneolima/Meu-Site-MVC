using Microsoft.AspNetCore.Mvc;

namespace MeuSiteMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
