﻿using Microsoft.AspNetCore.Mvc;
using AspNetProject.Filters;
using AspNetProject.Models;

namespace AspNetProject
{
    public class ExchangesController : Controller
    {
        [ServiceFilter(typeof(MyCustomActionFilter))]
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            // TODO add to database

            var viewModel = new AddNewItemConfirmationViewModel
            {
                Id = 1,
                Name = item.Name,
            };

            return View("AddConfirmation", viewModel);
        }
    }
}
