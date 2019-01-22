using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender emailSender;

        internal HomeController(IEmailSender emailSender) => this.emailSender = emailSender;

        public IActionResult Index()
        {
            emailSender.SendEmail("pavel_bory@plus4u.net", "Hello from ASP.NET Core");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contanct.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
