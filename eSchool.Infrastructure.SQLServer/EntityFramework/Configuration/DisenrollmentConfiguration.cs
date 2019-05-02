using eSchool.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Persistence.EntityFramework
{
    public class DisenrollmentConfiguration : IEntityTypeConfiguration<Disenrollment>
    {
        public void Configure(EntityTypeBuilder<Disenrollment> builder)
        {
            builder.Property(e => e.Id).HasColumnName("DisenrollmentId");
            builder.Property(e => e.Comment).IsRequired().HasMaxLength(100);
            builder.Property<DateTime>("LastUpdated");
            builder.Property<String>("LastUpdatedBY");
        }
    }
}
