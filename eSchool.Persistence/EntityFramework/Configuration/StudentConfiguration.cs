
using eSchool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Persistence.EntityFramework
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(e => e.Id).HasColumnName("StudentId");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);

            //Value object
            builder.OwnsOne(o => o.StudentCode);

            //Shadow properties
            builder.Property<DateTime>("LastUpdated");
            builder.Property<String>("LastUpdatedBY");

            //Back Field
            builder.HasMany(b => b.Enrollments)
              .WithOne()
              .HasForeignKey("StudentId")
               .HasForeignKey("CourseId")
              .OnDelete(DeleteBehavior.Cascade);
            var navigationEnrollment = builder.Metadata.FindNavigation(nameof(Student.Enrollments));
            navigationEnrollment.SetPropertyAccessMode(PropertyAccessMode.Field);

            //Back Field
            builder.HasMany(b => b.Disenrollments)
              .WithOne()
              .HasForeignKey("StudentId")
               .HasForeignKey("CourseId")
              .OnDelete(DeleteBehavior.Cascade);
            var navigationDisenrollment = builder.Metadata.FindNavigation(nameof(Student.Disenrollments));
            navigationDisenrollment.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
