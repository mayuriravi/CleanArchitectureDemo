using CleanArchitectureDemo.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.PersistenceGateway.SqlServer.Configuration
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasOne(e=>e.Student)
                .WithMany(f=>f.Enrollments)
                .HasForeignKey(p=>p.)
        }
    }
}
