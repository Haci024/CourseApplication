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
    public class PaymentsConfig : IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Students).WithMany(x=>x.Payments).HasForeignKey(x=>x.StudentId);
            builder.Property(x => x.MonthlyPayment).HasPrecision(6, 2);
            builder.Property(x=>x.PaidedMoney).HasPrecision(6, 2);
            builder.HasOne(x => x.Reservator).WithMany(x => x.Payments).HasForeignKey(x => x.ReservatorId);
            builder.Property(x=>x.AddedDate).HasColumnType("timestamp");
            
            
        }
    }
}
