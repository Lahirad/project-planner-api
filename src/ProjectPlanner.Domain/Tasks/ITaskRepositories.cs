using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Tasks
{
    interface ITaskRepositories
    {
        Task<Tasks?> AddTaskAsync(Tasks task, CancellationToken cancellationToken);
        Task<Tasks?> GetTaskByIdAsync(Guid id, CancellationToken cancellationToken);    
    }
}
