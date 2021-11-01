using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SqlServer
{
    public class DbContextEF : DbContext
    {
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=UnitOfWorkExampleDb;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbSet<Drinks> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
