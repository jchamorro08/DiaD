using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DayD.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product {get; set; }
        public DbSet<Clientes> Cliente {get; set; }
    }
    
}