using Microsoft.AspNetCore.Mvc;
using AspNetProject.Filters;
using AspNetProject.Models;

namespace AspNetProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesSecondController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public ExchangesSecondController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult Post(ItemModel model)
        {
            var entity = new ItemEntity
            {
                Name = model.Name,
                Description = model.Description,
                IsVisible = model.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
