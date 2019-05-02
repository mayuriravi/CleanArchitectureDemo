using CleanArchitectureDemo.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.PersistenceGateway.SqlServer.Configuration
{
    public class CourseConfiguration: IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
    {
            builder.Property(e => e.Id).HasColumnName("CourseId");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            //builder.Property(e=>e.Credits).HasColumnType()
        }
}
}
    