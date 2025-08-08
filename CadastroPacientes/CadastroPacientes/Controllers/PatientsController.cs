using Microsoft.AspNetCore.Mvc;

namespace CadastroPacientes.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
