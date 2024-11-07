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
    public class OptionsConfig : IEntityTypeConfiguration<Options>
    {
        public void Configure(EntityTypeBuilder<Options> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Questions).WithMany(x=>x.Options).HasForeignKey(x=>x.QuestionId);  

            
        }
    }
}
