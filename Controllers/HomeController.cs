using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Phone.Models;

namespace Phone.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public string ShowMessage()
    {
        return "Welcome to Tuwaiq";
    }

    public int Square(int num)
    {
        return num * num;
    }

    public void Square1 (int num)
    {
        int result = num *num;
        Console.WriteLine($"[Console Output] The square of {num} is:{result}");
    }

    public int Add(int num1 , int num2)
    {
        return num1+num2;
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
