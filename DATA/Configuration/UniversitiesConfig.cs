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
    public class UniversitiesConfig : IEntityTypeConfiguration<Universities>
    {
        public void Configure(EntityTypeBuilder<Universities> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Students).WithOne(x => x.Universities).HasForeignKey(x => x.UniversityId);

        }
    }
}
