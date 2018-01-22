using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreV1.Data.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNetCoreV1._0.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _iCategoryRepository;
        private readonly IDrinkRepository _iDrinkRepository;

        public DrinkController(ICategoryRepository iCategoryRepository, IDrinkRepository iDrinkRepository)
        {
            this._iCategoryRepository = iCategoryRepository;
            this._iDrinkRepository = iDrinkRepository;
        }
        public IActionResult Index()
        {
            var drinks = _iDrinkRepository.Drinks;
            return View(drinks);
        }
    }
}
