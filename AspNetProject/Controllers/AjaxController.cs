using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    [ApiController]
    [Route("api/AjaxController")]
    public class AjaxController : ControllerBase
    {

        public IActionResult Post(ItemModel item)
        {

            return null;
        }
    }
}
