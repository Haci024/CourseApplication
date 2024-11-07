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
    public class FilialConfig : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.AppUserFilial).WithOne(x=>x.Filial).HasForeignKey(x=>x.FilialId);
            builder.HasMany(x => x.Groups).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasOne(x=>x.Packets).WithMany(x=>x.Filials).HasForeignKey(x=>x.PacketId);
            
        }
    }
}
