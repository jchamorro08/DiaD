using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DayD.Models;

namespace DayD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private BloggingContext ContextCategory;
        public CategoryController(BloggingContext parametro)
        {
            ContextCategory = parametro;
        }

        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            var user = ContextCategory.Category.FirstOrDefault(x => x.CategoryId == id);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("Simio");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return ContextCategory.Category.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Category value)
        {
            ContextCategory.Category.Add(value);
            ContextCategory.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category value)
        {
            var category = ContextCategory.Category.Find(id);
            if (category != null)
            {
                category.Title = value.Title;
                category.Content = value.Content;
                ContextCategory.SaveChanges();
            }
            else
            {
                Console.WriteLine("Quieres Modificar algo que no existe");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var remove = ContextCategory.Cliente.Find(id);
            if (remove != null)
            {
                ContextCategory.Cliente.Remove(remove);
                ContextCategory.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound("ALFIIIIIIIIIIIIIIIINNNNNNNNN");
            }

        }
    }
}
