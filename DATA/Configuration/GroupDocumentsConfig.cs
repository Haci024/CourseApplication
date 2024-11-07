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
    public class GroupDocumentsConfig : IEntityTypeConfiguration<GroupDocuments>
    {
        public void Configure(EntityTypeBuilder<GroupDocuments> builder)
        {
            builder.HasKey(x => new { x.GroupId, x.DocumentsId });
            builder.HasOne(x=>x.Groups).WithMany(x=>x.GroupDocuments).HasForeignKey(x=>x.GroupId);
            builder.HasOne(x => x.Documents).WithMany(x => x.GroupDocuments).HasForeignKey(x => x.DocumentsId);
        }
    }
}
