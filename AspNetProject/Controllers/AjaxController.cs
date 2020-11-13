using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AjaxController : ControllerBase
    {
        [HttpPost]
        public ItemModel Post(ItemModel item)
        {
            return item;
        }
    }
}
