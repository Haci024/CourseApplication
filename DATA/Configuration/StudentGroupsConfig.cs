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
    public class StudentGroupsConfig:IEntityTypeConfiguration<StudentGroups>
    {
        public void Configure(EntityTypeBuilder<StudentGroups> builder)
        {
            builder.HasKey(x =>x.StudentGroupsId);
            builder.HasOne(x=>x.Students).WithMany(x=>x.StudentGroups).HasForeignKey(x=>x.StudentId);
            builder.HasOne(x=>x.Groups).WithMany(x=>x.StudentGroups).HasForeignKey(x=>x.GroupId);
            builder.HasMany(x => x.Schedules).WithOne(x => x.StudentGroups).HasForeignKey(x => x.StudentGroupId);
        }

       
    }
}
