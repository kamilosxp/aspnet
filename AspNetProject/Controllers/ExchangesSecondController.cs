using Microsoft.AspNetCore.Mvc;
using AspNetProject.Filters;
using AspNetProject.Models;

namespace AspNetProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesSecondController : ControllerBase
    {
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult Post(ItemModel model)
        {
            return Ok();
        }
    }
}
