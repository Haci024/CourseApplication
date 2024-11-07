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
    public class GroupsConfig : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.GroupDocuments).WithOne(x=>x.Groups).HasForeignKey(x=>x.GroupId);
            builder.HasMany(x=>x.TeacherGroups).WithOne(x=>x.Groups).HasForeignKey(x=>x.TeacherId);
            builder.HasMany(x => x.StudentGroups).WithOne(x => x.Groups).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Filial).WithMany(x => x.Groups).HasForeignKey(x => x.FilialId);
            


        }
    }
}
