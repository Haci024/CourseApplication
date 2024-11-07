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
    public class ExamQuestionsConfig : IEntityTypeConfiguration<ExamQuestions>
    {
        public void Configure(EntityTypeBuilder<ExamQuestions> builder)
        {
            builder.HasKey(x => new {x.ExamId, x.QuestionId});
            builder.HasOne(x=>x.Questions).WithMany(x=>x.ExamQuestions).HasForeignKey(x => x.QuestionId);
            builder.HasOne(x => x.Exams).WithMany(x => x.ExamQuestions).HasForeignKey(x => x.ExamId);
        }
    }
}
