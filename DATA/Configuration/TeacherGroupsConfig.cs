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
    public class TeacherGroupsConfig : IEntityTypeConfiguration<TeacherGroups>
    {
        public void Configure(EntityTypeBuilder<TeacherGroups> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Groups).WithMany(x=>x.TeacherGroups).HasForeignKey(x=>x.GroupId);
            builder.HasMany(x=>x.LessonsTitles).WithOne(x=>x.TeacherGroups).HasForeignKey(x=>x.TeacherGroupsId);
            builder.HasOne(x=>x.Teachers).WithMany(x=>x.TeacherGroups).HasForeignKey(x=>x.TeacherId);
            
        }
    }
}
