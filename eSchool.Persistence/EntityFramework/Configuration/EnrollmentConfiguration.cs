
using eSchool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Persistence.EntityFramework
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.Property(e => e.Id).HasColumnName("EnrollmentId");
            builder.Property<DateTime>("LastUpdated");
            builder.Property<String>("LastUpdatedBY");

            

        }

    }
}
