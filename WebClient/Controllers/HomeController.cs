using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.SqlServer;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnitOfwork.Interfaces;
using UnitOfWork.SqlServer;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ICoctailServiceAdoNet _coctailServiceAdoNet;
        //private IUnitOfWorkEF unitOfWork;
        //private ICoctailServiceEF coctailService;
        //private ICoctailServiceMockService _coctailServiceMockService;

        public HomeController(ILogger<HomeController> logger/*, ICoctailServiceAdoNet coctailServiceAdoNet, ICoctailServiceMockService coctailServiceMockService*/)
        {
            _logger = logger;
            //_coctailServiceAdoNet = coctailServiceAdoNet;
            //var context = new DbContextEF();
            //unitOfWork = new UnitOfWorkContainerEF(context);
            //coctailService = new CoctailServiceEF(unitOfWork);

            //_coctailServiceMockService = coctailServiceMockService;

        }

        public IActionResult Index()
        {
            return View();
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
}
