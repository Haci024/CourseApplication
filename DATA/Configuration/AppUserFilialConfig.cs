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
    public class AppUserFilialConfig : IEntityTypeConfiguration<AppUserFilial>
    {
        public void Configure(EntityTypeBuilder<AppUserFilial> builder)
        {
            builder.HasKey(x => new { x.AppUserId, x.FilialId });
            builder.HasOne(x => x.Filial).WithMany(x => x.AppUserFilial).HasForeignKey(x => x.FilialId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserFilial).HasForeignKey(x => x.AppUserId);
        }
    }
}
