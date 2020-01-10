using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("Categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("First")]
        public string Get()
        {
            return "GET"; 
        }

        [HttpGet]
        [Route("First/{id:int}")]
        public string GetById(int id)
        {
            return "Get " + id.ToString(); 
        }
        
        [HttpPost]
        [Route("First")]
        public Category Post([FromBody]Category model)
        {
            return model; 
        }
        
        [HttpPut]
        [Route("First/{id:int}")]
        public Category Put(int id, [FromBody]Category titulo)
        {
            return titulo; 
        }
        
        [HttpDelete]
        [Route("First")]
        public string Delete()
        {
            return "Delete"; 
        }
    }
}