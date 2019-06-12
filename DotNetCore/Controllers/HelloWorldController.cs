using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DotNetCore.Controllers
{
    public class HelloWorldController : Controller
    {

        //public string Index()
        //{
        //    return "Hello World from Hello world controller";
        //}

        public string Welcome()
        {
            return "Welcome from Hello world controller";
        }

        public IActionResult WelcomeP(string name, int id)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, Id {id}");
            ViewData["Message"] = "This is hard cord message from controller";
            ViewData["From"] = name;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}