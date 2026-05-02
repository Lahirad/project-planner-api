using ProjectPlanner.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Users
{
    public sealed class Users : Entity
    {
        public Users(Guid id,Email email, Name name, DateTime createdAt) :base(id)
        {
            Email = email;
            Name = name;
            CreatedAt = createdAt;

        }
        public Email Email { get; private set; }
        public Name Name { get; private set; }

        public string IdentityId { get; private set; } = string.Empty;

        public DateTime CreatedAt { get; protected set; } 
        public static Users Create(Email email, Name name,DateTime createdDate)
        {
            return new Users(Guid.NewGuid(), email, name, createdDate);
        }

        public void SetIdentityId(string identityId)
        {
            IdentityId = identityId;
        }
    }
}
