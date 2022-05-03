using MaxiBlockBuster.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiBlockBuster.DAL
{
    public class BlockBusterDbContext : DbContext
    {
        public BlockBusterDbContext()
        {
            base.Database.SetConnectionString(@"Server=DESKTOP-F5OLJ0E\sqlexpress;Database=MaxiBlockBuster;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

//        public BlockBusterDbContext(DbContextOptions<BlockBusterDbContext> options)
//: base(options)
//        {
//        }

        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-F5OLJ0E\sqlexpress;Database=MaxiBlockBuster;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
