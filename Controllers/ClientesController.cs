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

    public class ClientesController : ControllerBase
    {
        private BloggingContext ContextClientes;
        public ClientesController(BloggingContext parametro)
        {
            ContextClientes = parametro;
        }

        // GET api/values
        [HttpGet("{userName}")]
        public ActionResult<Clientes> Get(string userName)
        {
            var user = ContextClientes.Cliente.FirstOrDefault(x => x.userName == userName);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("Simio");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clientes>> Get()
        {
            return ContextClientes.Cliente.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Clientes value)
        {
            ContextClientes.Cliente.Add(value);
            ContextClientes.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{userName}")]
        public void Put(int id, [FromBody] Clientes value)
        {
            var Cliente = ContextClientes.Cliente.Find(id);
            if (Cliente != null)
            {
                Cliente.Nombre = value.Nombre;
                Cliente.Apellido = value.Apellido;
                Cliente.userName = value.userName;
                Cliente.Email= value.Email;
                ContextClientes.SaveChanges();
            }
            else
            {
                Console.WriteLine("Quieres Modificar algo que no existe");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{userName}")]
        public ActionResult Delete(string UserName)
        {
            var remove = ContextClientes.Cliente.Find(UserName);
            if (remove != null)
            {
                ContextClientes.Cliente.Remove(remove);
                ContextClientes.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound("ALFIIIIIIIIIIIIIIIINNNNNNNNN");
            }

        }
    }
}
