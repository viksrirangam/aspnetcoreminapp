using System;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from aspnetcore...";
        }
    }
}
