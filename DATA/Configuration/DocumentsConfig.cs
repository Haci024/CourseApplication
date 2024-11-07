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
    public class DocumentsConfig : IEntityTypeConfiguration<Documents>
    {
        public void Configure(EntityTypeBuilder<Documents> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.GroupDocuments).WithOne(x => x.Documents).HasForeignKey(x => x.DocumentsId);

        }
    }
}
