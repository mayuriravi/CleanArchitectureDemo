using System;
using eSchool.Domain;
using Microsoft.EntityFrameworkCore;


namespace eSchool.Persistence.EntityFramework
{
    public class eSchoolSqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public eSchoolSqlDbContext(DbContextOptions options) : base(options) 
        { }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Disenrollment> Disenrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            SingularizeEntityTableNames(builder);
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new DisenrollmentConfiguration());
            builder.ApplyConfiguration(new EnrollmentConfiguration());
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Property("LastUpdated").CurrentValue = DateTime.UtcNow;
                    entry.Property("LastUpdatedBy").CurrentValue = "System";
                }
            }
            return base.SaveChanges();
        }
        private void SingularizeEntityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Disenrollment>().ToTable("Disenrollment");
        }

        
    }
}

