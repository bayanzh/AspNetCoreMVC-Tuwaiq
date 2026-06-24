using Microsoft.AspNetCore.Mvc;
namespace Tuwaiq.Controllers
{
    public class TuwaiqController : Controller
{
    public IActionResult Index()
    {
        return Content("Welcome to Tuwaiq Academy");
    }

    public IActionResult Bootcamp(string track)
{
    return Content($"You are enrolled in the {track} Bootcamp!");
}
    private static string[] ArrayProduct = new string[]
    {
        "iPhone",
        "Screen",
        "Mouse",
        "Keyboard"
    };

    public string GetItem(string name)
        {
            if (Array.Exists(ArrayProduct, element => element == name ))
            {
                return "found";
            }
            else
            {
                return "not found";
            }
        }

    private static List<string> ListProduct = new List<string>()
    {
         "iPhone",
        "Screen",
        "Mouse",
        "Keyboard"
    };
    public string GetItems(string name)
        {
            if (ListProduct.Contains(name))
            {
                return "found";
            }
            else
            {
                return "not found";
            }
        }


}
}