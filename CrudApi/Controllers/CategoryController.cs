using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CrudDbContext _crudDbContext;

        public CategoryController(CrudDbContext crudDbContext)
        {
            _crudDbContext = crudDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_crudDbContext.Categories.ToList());
        }
    }
}
