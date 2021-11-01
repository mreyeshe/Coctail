using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClient.Controllers
{
    public class DrinksController : Controller
    {

        private ICoctailServiceMockService _coctailServiceMockService;

        public DrinksController(ICoctailServiceMockService coctailServiceMockService)
        {
            _coctailServiceMockService = coctailServiceMockService;

        }

        // GET: DrinksController
        public ActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> SearchDrinks(string query, string typeSearch)
        {
            try
            {
                List<Drink> items = new List<Drink>();

                if (typeSearch == "ByName")
                {
                    items = _coctailServiceMockService.SearchDrinksByName(query).Result.ToList();
                }
                if (typeSearch == "ByIngredient")
                {
                    items = _coctailServiceMockService.SearchDrinksByIngredient(query).Result.ToList();
                }

                if (items.Count > 0)
                {
                    return Json(items.ToArray());
                }
                return Json(new List<Drink>().ToArray());
            }
            catch (Exception e)
            {
                return Json(new List<Drink>().ToArray());
            }
        }


        [HttpGet]
        public IActionResult Detail(long idDrink)
        {
            try
            {
                Drink item = new Drink();

                if (idDrink > 0)
                {
                    item = _coctailServiceMockService.GetDrinkById(idDrink).Result;

                    return View(item);
                }
                return View(new Drink());
            }
            catch (Exception ex)
            {
                return View(new Drink());
            }
        }
    }
}
