using System;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp.controllers
{
    public class HomeController : Controller
    {
        public string Hello()
        {
            return "Hello from aspnetcore...";
        }
        
        public IActionResult Index()
			{
			    return View();
			}
    }
}
