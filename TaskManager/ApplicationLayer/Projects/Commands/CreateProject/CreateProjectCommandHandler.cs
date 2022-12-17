using ApplicationLayer.Projects.Commands.Contexts;
using ApplicationLayer.Projects.Commands.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.Projects.Commands.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private readonly TaskManagerDbContext _dbContext;
        public CreateProjectCommandHandler(TaskManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project
            {
                Id = request.Id,
                Name = request.Name,
                StartDate = DateTime.Now,
                projectStatus = ProjectStatus.NotStarted
            };
            await _dbContext.Projects.AddAsync(project, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return project.Id;
        }
    }
}
