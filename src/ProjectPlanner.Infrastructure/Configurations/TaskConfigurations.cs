using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Infrastructure.Configurations
{
    internal sealed class TaskConfigurations : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("TASKS");
            builder.HasKey(x => x.Id);  

            builder.Property(x => x.Id).HasColumnName("ID");


        }
    }
}
