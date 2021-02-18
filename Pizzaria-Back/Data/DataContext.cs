using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webapidotnet.Model;

namespace webapidotnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Restaurante>()
                     .HasData(new List<Restaurante>()
                     {
                         new Restaurante(1, "Tropeiro"),

         });
            builder.Entity<Pizza>()
                    .HasData(new List<Pizza>()
                    {
                         new Pizza(1, "Calabresa", 33),

                    });
        }
    }
}
