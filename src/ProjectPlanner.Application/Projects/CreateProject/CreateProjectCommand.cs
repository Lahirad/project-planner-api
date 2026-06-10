using ProjectPlanner.Application.Messging;
using ProjectPlanner.Domain.Projectes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectPlanner.Application.Projects.CreateProject
{
   public record CreateProjectCommand(Guid UserId
                                      ,Title Title
                                      ,Description Description
                                      ,DateTime StartDate
                                      ,DateTime EndDate
                                      ,Status Status
                                      ,DateRange Duration) : ICommand<Guid>;    
}
 