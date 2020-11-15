using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public ItemsController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var items = _dbContext.Items.ToList();

            return View("Index", items);
        }
    }
}
