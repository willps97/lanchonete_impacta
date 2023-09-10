﻿using LanchoneteImpacta.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchoneteImpacta.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
