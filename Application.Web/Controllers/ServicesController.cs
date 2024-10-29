using Microsoft.AspNetCore.Mvc;

namespace Application.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
