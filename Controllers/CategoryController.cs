using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shop.Models;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById([FromQuery] int id)
        {
            return new Category();
        }

        [HttpPost]
        public  async Task<ActionResult<List<Category>>> Post(int id, [FromBody] Category model)
        {
            if (id != model.Id)
                return NotFound(new { message = "Categoria não encontrada" });

            //Verifica se os dados são validos
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> Put(int id, [FromBody] Category model)
        {
            if (model.Id == id)
            {
                return Ok(model);
            }
            return NotFound();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
