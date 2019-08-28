using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DayD.Models
{
public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public int Precio { get; set; }
        public List<Category> Category { get; set; }
        public string Description { get; set; }
        public string Other { get; set; }
    }
}