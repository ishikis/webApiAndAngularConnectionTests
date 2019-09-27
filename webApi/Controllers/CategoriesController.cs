using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        fakeDatabase contex;
        public CategoriesController()
        {
            if (this.contex == null)
                contex = new fakeDatabase();
        }


        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return contex.categories;
        }


        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return contex.categories.Find(x => x.id == id);
        }

    }
}