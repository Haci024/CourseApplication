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
    public class PacketsConfig : IEntityTypeConfiguration<Packets>
    {
        public void Configure(EntityTypeBuilder<Packets> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.HasMany(x=>x.Filials).WithOne(x=>x.Packets).HasForeignKey(x=>x.PacketId);
        }
    }
}
