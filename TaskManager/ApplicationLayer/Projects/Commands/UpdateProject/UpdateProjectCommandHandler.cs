using ApplicationLayer.Projects.Commands.Contexts;
using ApplicationLayer.Projects.Commands.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand>
    {
        private readonly TaskManagerDbContext _dbContext;
        public UpdateProjectCommandHandler(TaskManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Projects.FirstOrDefaultAsync(proj => proj.Id == request.Id, cancellationToken);
            if(entity == null || entity.Id != request.Id)
            {
                throw new ArgumentException(nameof(Project), "not found");
            }
            entity.Priority = request.Priority;
            entity.projectStatus = request.projectStatus;
            return Unit.Value;
        }
    }
}
