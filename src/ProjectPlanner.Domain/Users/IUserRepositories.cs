using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Users
{
    interface IUserRepositories
    {
        Task<Users?> AddUserAsync(Users user,CancellationToken cancellationToken);
        Task<Users?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
