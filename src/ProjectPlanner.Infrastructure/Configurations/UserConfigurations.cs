using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPlanner.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Infrastructure.Configurations
{
    internal sealed class UserConfigurations : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("PROJECT_USERS"); 

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");

            builder.Property(x => x.Email)
                    .HasConversion(
                        email => email.Value,
                        value => new Email(value))
                    .IsRequired().HasColumnName("EMAIL");

            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.Name).HasMaxLength(2000).IsRequired().HasColumnName("NAME");
            builder.Property(x => x.CreatedAt).IsRequired().HasColumnName("CREATED_AT");
            builder.Property(x => x.IdentityId).HasMaxLength(200).HasColumnName("IDENTITY_ID").IsRequired(false);

            builder.Property<uint>("Version").HasColumnName("VERSION").IsRowVersion();
        }
    }
}

