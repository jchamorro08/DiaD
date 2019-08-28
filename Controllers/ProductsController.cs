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

    public class ProductController : ControllerBase
    {
        private BloggingContext ContextProducts;
        public ProductController(BloggingContext parametro)
        {
            ContextProducts = parametro;
        }

        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var user = ContextProducts.Product.FirstOrDefault(x => x.ProductId == id);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("Simio");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return ContextProducts.Product.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            ContextProducts.Product.Add(value);
            ContextProducts.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            var Product = ContextProducts.Product.Find(id);
            if (Product != null)
            {
                Product.Title= value.Title;
                Product.Description = value.Description;
                Product.Other = value.Other;
                Product.Precio = value.Precio;
                ContextProducts.SaveChanges();
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
            var remove = ContextProducts.Product.Find(id);
            if (remove != null)
            {
                ContextProducts.Product.Remove(remove);
                ContextProducts.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound("ALFIIIIIIIIIIIIIIIINNNNNNNNN");
            }

        }
    }
}
