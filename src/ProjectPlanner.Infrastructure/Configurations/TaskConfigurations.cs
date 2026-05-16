using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using ProjectPlanner.Domain.Tasks;
namespace ProjectPlanner.Infrastructure.Configurations
{
    internal sealed class TaskConfigurations : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.ToTable("TASKS");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");

            builder.Property(x => x.ProjectId).HasColumnName("PROJECT_ID").IsRequired();

            builder.Property(x => x.Title).HasMaxLength(2000).IsRequired().HasColumnName("TITLE");

            builder.Property(x => x.Description).HasMaxLength(4000).IsRequired().HasColumnName("DESCRIPTION");

            builder.Property(x => x.TaskStatus).HasConversion<string>().IsRequired().HasColumnName("TASK_STATUS");

            builder.Property(x => x.TaskPriority).HasConversion<string>().IsRequired().HasColumnName("TASK_PRIORITY");

            builder.Property(x => x.DueDate).IsRequired().HasColumnName("DUE_DATE");

            builder.Property(x => x.CreatedAt).IsRequired().HasColumnName("CREATED_AT");

            builder.Property(x => x.AssignedTo).HasColumnName("ASSIGNED_TO").IsRequired();

            builder.Property<uint>("Version").HasColumnName("VERSION").IsRowVersion();

            builder.HasOne<Domain.Projectes.Projects>()
               .WithMany()
               .HasForeignKey(x => x.ProjectId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ProjectPlanner.Domain.Users.Users>()
            .WithMany()
            .HasForeignKey(x => x.AssignedTo)
            .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
