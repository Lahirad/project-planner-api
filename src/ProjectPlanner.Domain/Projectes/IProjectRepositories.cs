using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Projectes
{
    public interface IProjectRepositories
    {
        Task<Projects?> AddProjectAsync(Projects project, CancellationToken cancellationToken);
        Task<Projects?> GetProjectByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
