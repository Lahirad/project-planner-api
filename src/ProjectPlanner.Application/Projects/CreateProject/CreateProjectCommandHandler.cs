using ProjectPlanner.Application.Abstractions.Clock;
using ProjectPlanner.Application.Messging;
using ProjectPlanner.Domain.Abstractions;
using ProjectPlanner.Domain.Projectes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Application.Projects.CreateProject
{
    internal sealed class CreateProjectCommandHandler : ICommandHandler<CreateProjectCommand, Guid>
    {
        private readonly IProjectRepositories _projectRepositories;
        private readonly IUnitofWork _unitofwork;
        private readonly IDateTimeProvider _dateTimeProvider;
        public CreateProjectCommandHandler(IProjectRepositories projectRepositories
                                           ,IUnitofWork unitofWork
                                           ,IDateTimeProvider dateTimeProvider
                                          )
        {
            _projectRepositories = projectRepositories;
            _unitofwork = unitofWork;
            _dateTimeProvider = dateTimeProvider;
        }
        public async Task<Result<Guid>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            //var project = _projectRepositories.AddProjectAsync(Projects.CreateProject(Guid.NewGuid));
            throw new NotImplementedException();
        }
    }
}
