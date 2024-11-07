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
    public class AttendenceConfig : IEntityTypeConfiguration<Attendence>
    {
        public void Configure(EntityTypeBuilder<Attendence> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Schedule).WithMany(x => x.Attendence).HasForeignKey(x => x.ScheduleId);
            builder.HasOne(x => x.Student).WithMany(x => x.Attendence).HasForeignKey(x => x.ScheduleId);

        }
    }
}
