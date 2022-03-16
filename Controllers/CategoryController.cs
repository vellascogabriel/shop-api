using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "GET";
        }

        [HttpPost]
        public string Post()
        {
            return "POST";
        }

        [HttpPut]
        public string Put()
        {
            return "Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "DELETE";
        }
    }
}
