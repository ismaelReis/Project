﻿using Microsoft.EntityFrameworkCore;
using SidimEsus.Models;

namespace SidimEsus.Repos
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options)
        {

        }

        public DbSet<Cidadao> Cidadaos { get; set; }
        public DbSet<VisitaDomiciliar> VisitasDomiciliar { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
