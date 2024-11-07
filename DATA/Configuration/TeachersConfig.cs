using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class TeachersConfig : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.HasKey(x=> x.Id);   
            builder.HasMany(x=>x.TeacherGroups).WithOne(x=>x.Teachers).HasForeignKey(x=>x.TeacherId);
            builder.HasOne(x => x.AppUser).WithOne(x => x.Teachers);

        }
    }
}
