using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Data;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            List<Slider> sliders = _context.Sliders.ToList();


            List<Work> works = _context.Works.ToList();


            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                Works = works
            };

            return View(model);
        }
    }
}
