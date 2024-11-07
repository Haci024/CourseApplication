using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.HasMany(x => x.AppUserFilial).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Students).WithOne(x => x.AppUser).HasForeignKey<Students>(x=>x.AppUserId);
            builder.HasOne(x=>x.Teachers).WithOne(x => x.AppUser).HasForeignKey<Teachers>(x=>x.AppUserId);
            builder.HasMany(x=>x.Notfications).WithOne(x=>x.Receiver).HasForeignKey(x=>x.AppUserId);
           
            
        }
    }
}
