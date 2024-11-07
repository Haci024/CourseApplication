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
    public class QuestionsConfig : IEntityTypeConfiguration<Questions>
    {
        public void Configure(EntityTypeBuilder<Questions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.Options).WithOne(x=>x.Questions).HasForeignKey(x=>x.QuestionId);
            builder.HasMany(x => x.ExamQuestions).WithOne(x => x.Questions).HasForeignKey(x => x.QuestionId);
        }
    }
}
