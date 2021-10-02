
using Microsoft.EntityFrameworkCore;
using SchoolsAdministrator.Core.Entities;

namespace SchoolsAdministrator.Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SchoolConfiguration());
            builder.ApplyConfiguration(new ClassroomConfiguration());
        }


    }
}
