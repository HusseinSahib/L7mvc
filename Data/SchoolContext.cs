using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2021-03-13-hn98-dykstra1] -The preceding code creates a DbSet property for each entity set.An entity set typically corresponds to a database table.An entity corresponds to a row in the table.
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tinfo200:[2021-03-13-hn98-dykstra1] -When the database is created, EF creates tables that have names the same as the DbSet property names.This behavior is overridden by specifying singular table names in the DbContext
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}