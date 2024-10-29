using Application.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Overview()
        {
            var service = new VehicleService();
            service.ServiceId = 1;
            service.ServiceCategory = "Gas Fill";
            service.Details = "Refueling service with premium gasoline";
            service.Price = "50.00";
            service.IsDeleted = false;

            return View();
        }
    }
}
