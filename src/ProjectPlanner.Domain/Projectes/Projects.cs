using ProjectPlanner.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Projectes
{
    public sealed class Projects : Entity
    {
        private Projects(Guid Id, Guid userId, Title title, Description description, DateRange duration, DateTime createdAt, Status status)  : base(Id)
        {
            UserId = userId;
            Title = title;
            Description = description;
            Duration = duration;
            CreatedAt = createdAt;
            Status = status;
        }

        public Guid UserId { get; private set; }
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public DateTime CreatedAt { get;protected set; }
        public Status Status { get; private set; }
        public DateRange Duration { get; private set; }

        public static Projects Create(Guid userId, Title title, Description description, DateRange duration, Status status)
        {
            return new Projects(
                Guid.NewGuid(),
                userId,
                title,
                description,
                duration,
                DateTime.UtcNow,
                status
            );
        }
    }
}
