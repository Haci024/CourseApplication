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
    public class NotficationsConfig : IEntityTypeConfiguration<Notfications>
    {
        public void Configure(EntityTypeBuilder<Notfications> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Receiver).WithMany(x=>x.Notfications).HasForeignKey(x=>x.AppUserId);
        }
    }
}
