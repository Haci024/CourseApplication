using Data.Configuration;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbConnection
{
    public class AppDbContext:IdentityDbContext<AppUser,IdentityRole<Guid>,Guid>
    {
        public DbSet<TestTable> Table { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=Odissey;initial catalog=GoldElectronicsDb;integrated Security=true;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("server=Odissey;initial catalog=OdisseyElectroDB;integrated Security=true;TrustServerCertificate=true");
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=CourseApplicationDb;User Id=postgres;Password=12345");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new TestConfig());    
            
         
        }
    }
}

