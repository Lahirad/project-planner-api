using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPlanner.Domain.Projectes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Infrastructure.Configurations
{
    internal sealed class ProjectConfigurations : IEntityTypeConfiguration<Projects>
    {
        public void Configure(EntityTypeBuilder<Projects> builder)
        {
            builder.ToTable("PROJECTS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");

            builder.Property(x => x.UserId).HasColumnName("USER_ID").IsRequired();      

            builder.Property(x => x.Title).HasConversion(
                title => title.Value,
                value => new Title(value)).HasMaxLength(2000).IsRequired().HasColumnName("TITLE");

            builder.Property(x => x.Description).HasConversion(
                description => description.Value,
                value => new Description(value)).HasMaxLength(2000).IsRequired().HasColumnName("DESCRIPTION");

            builder.Property(x => x.StartDate).HasColumnName("START_DATE").IsRequired();

            builder.Property(x => x.EndDate).HasColumnName("END_DATE").IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired().HasColumnName("CREATED_AT");

            builder.Property(x => x.Status)
                            .HasConversion<string>()
                            .HasMaxLength(200)
                            .IsRequired()
                            .HasColumnName("STATUS");

            builder.Property<uint>("Version").HasColumnName("VERSION").IsRowVersion();  
        }
    }
}
