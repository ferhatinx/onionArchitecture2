using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class OnionConttext : DbContext
    {
        public OnionConttext(DbContextOptions<OnionConttext> options) : base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[]
            { 
                new Product() {Id=1,Name="Buzdolabı",Value=10000,Quantity=20},
                new Product() {Id=2,Name="Televizyon",Value=8000,Quantity=10},
                new Product() {Id=3,Name="Telefon",Value=500,Quantity=100},
                new Product() {Id=4,Name="Bilgisayar",Value=20000,Quantity=5},
            });
        }
    }

}
