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
    public class StudentConfig : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.Payments).WithOne(x=>x.Students).HasForeignKey(x=>x.StudentId);
            builder.HasOne(x => x.Universities).WithMany(x => x.Students).HasForeignKey(x => x.UniversityId);
            builder.Property(x=>x.BachelorPoint).HasPrecision(5,2);
            builder.Property(x => x.TotalPayments).HasPrecision(6,2);
            builder.Property(x => x.AddingDate).HasColumnType("timestamp");

        }
    }
}
