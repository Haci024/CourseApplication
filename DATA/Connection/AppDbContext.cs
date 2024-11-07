using Data.Configuration;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Connection
{
    public class AppDbContext:IdentityDbContext<AppUser,IdentityRole<Guid>,Guid>
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<TeacherGroups> TeacherGroups { get; set; }
        public DbSet<StudentGroups> StudentGroups { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<Filial> Filials { get; set; }
        public DbSet<AppUserFilial> AppUserFilials { get; set; }
        public DbSet<LessonTitle> AnswerLists { get; set; }
        public DbSet<Attendence> AttendenceList { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Universities> Universities { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<GroupDocuments> GroupDocuments { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }
        public DbSet<StudentAnswers> StudentAnswers { get; set; }
        public DbSet<Packets> Packets { get; set; }
        public DbSet<Notfications> Notfications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=Odissey;initial catalog=GoldElectronicsDb;integrated Security=true;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("server=Odissey;initial catalog=OdisseyElectroDB;integrated Security=true;TrustServerCertificate=true");
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=CourseApplicationDb;User Id=postgres;Password=12345");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppUserFilialConfig());
            builder.ApplyConfiguration(new AttendenceConfig());
            builder.ApplyConfiguration(new DocumentsConfig());
            builder.ApplyConfiguration(new ExamQuestionsConfig());
            builder.ApplyConfiguration(new ExamsConfig());
            builder.ApplyConfiguration(new FilialConfig());
            builder.ApplyConfiguration(new GroupDocumentsConfig());
            builder.ApplyConfiguration(new GroupsConfig());
            builder.ApplyConfiguration(new LessonTitleConfig());
            builder.ApplyConfiguration(new OptionsConfig());
            builder.ApplyConfiguration(new PaymentsConfig());
            builder.ApplyConfiguration(new QuestionsConfig());
            builder.ApplyConfiguration(new ScheduleConfig());
            builder.ApplyConfiguration(new StudentAnswerConfig());
            builder.ApplyConfiguration(new StudentConfig());
            builder.ApplyConfiguration(new SubjectsConfig());
            builder.ApplyConfiguration(new StudentAnswerConfig());
            builder.ApplyConfiguration(new StudentGroupsConfig());
            builder.ApplyConfiguration(new TeacherGroupsConfig());
            builder.ApplyConfiguration(new TeachersConfig());
            builder.ApplyConfiguration(new UniversitiesConfig());
            
          
            
        }
    }
}

