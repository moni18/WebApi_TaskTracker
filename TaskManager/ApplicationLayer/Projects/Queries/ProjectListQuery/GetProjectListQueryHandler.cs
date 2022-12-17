using ApplicationLayer.Projects.Commands.Contexts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLayer.Projects.Queries.ProjectListQuery
{
    public class GetProjectListQueryHandler : IRequestHandler<GetProjectListQuery, ProjectListViewModel>
    {
        private readonly TaskManagerDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectListQueryHandler(TaskManagerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectListViewModel> Handle(GetProjectListQuery request, CancellationToken cancellationToken)
        {
            var projectQuery = await _dbContext.Projects
                .Where(proj => proj.Id == request.Id)
                .ProjectTo<ProjectListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ProjectListViewModel { Projects = projectQuery };
        }
    }
}
