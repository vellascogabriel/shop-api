using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public string MeuMetodo()
        {
            return "Olá Mundo!";
        }
    }
}
