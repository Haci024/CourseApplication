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
    public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x=> x.Id);   
            builder.HasMany(x=>x.Attendence).WithOne(x=>x.Schedule).HasForeignKey(x=>x.ScheduleId);
            builder.Property(x=>x.LessonDate).HasColumnType("timestamp");
        }
    }
}
