using Microsoft.AspNetCore.Mvc;
namespace Tuwaiq.Controllers
{
    

public class TestController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }



}