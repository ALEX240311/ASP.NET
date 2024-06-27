using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class TrangChu : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
