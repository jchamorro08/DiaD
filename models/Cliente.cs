using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DayD.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        public string userName { get; set; }
        public string Email { get; set; }
    }
}
