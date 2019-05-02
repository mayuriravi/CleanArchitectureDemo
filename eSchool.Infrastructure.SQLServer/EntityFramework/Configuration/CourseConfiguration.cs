
using eSchool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Persistence.EntityFramework
{
    public class CourseConfiguration: IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
    {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).HasColumnName("CourseId");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property<DateTime>("LastUpdated");
            builder.Property<String>("LastUpdatedBY");
        }
}
}
    