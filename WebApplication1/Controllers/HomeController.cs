using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /*public string Index()
        {
            return "Selamat datang pada praktikum .net";
        }*/

        public ActionResult Index()
        {
            return View();
        }
    }
}