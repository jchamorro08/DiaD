using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DayD.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
     }
}