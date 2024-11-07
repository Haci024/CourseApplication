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
    public class StudentAnswerConfig : IEntityTypeConfiguration<StudentAnswers>
    {
        public void Configure(EntityTypeBuilder<StudentAnswers> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.Questions).WithMany(x => x.StudentAnswers).HasForeignKey(x => x.QuestionId);
            builder.HasOne(x=>x.StudentExam).WithOne(x=>x.Exams).HasFore
          
        }
    }
}
