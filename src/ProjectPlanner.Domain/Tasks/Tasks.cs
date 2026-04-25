using ProjectPlanner.Domain.Abstractions;
using ProjectPlanner.Domain.Tasks.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectPlanner.Domain.Tasks
{
    public sealed class Tasks :  Entity
    {
        private Tasks(Guid Id , Guid projectId, string title, string description, Enums.TaskStatus taskStatus, TaskPriority taskPriority, DateTime dueDate, DateTime createdAt, Guid assignedTo) : base(Id)   
        {
            ProjectId = projectId;
            Title = title;
            Description = description;
            TaskStatus = taskStatus;
            TaskPriority = taskPriority;
            DueDate = dueDate;
            CreatedAt = createdAt;
            AssignedTo = assignedTo;
        }

        public Guid ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Enums.TaskStatus TaskStatus { get; private set; }
        public TaskPriority TaskPriority { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid AssignedTo { get; private set; }

        public static Tasks Create(Guid projectId, string title, string description, Enums.TaskStatus taskStatus, TaskPriority taskPriority, DateTime dueDate, Guid assignedTo)
        {
            return new Tasks(
                Guid.NewGuid(),
                projectId,
                title,
                description,
                taskStatus,
                taskPriority,
                dueDate,
                DateTime.UtcNow,
                assignedTo
            );
        }

    }
}
