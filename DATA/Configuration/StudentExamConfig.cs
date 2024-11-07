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
    public class StudentExamConfig : IEntityTypeConfiguration<StudentExam>
    {
        public void Configure(EntityTypeBuilder<StudentExam> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Students).WithMany(x=>x.StudentExams).HasForeignKey(x=>x.StudentId);
            builder.HasOne(x => x.Exams).WithMany(x => x.StudentExams).HasForeignKey(x => x.ExamId);

        }
    }
}
