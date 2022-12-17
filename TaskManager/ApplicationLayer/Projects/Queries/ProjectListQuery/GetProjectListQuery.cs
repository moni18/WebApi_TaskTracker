using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Queries.ProjectListQuery
{
    public class GetProjectListQuery : IRequest<ProjectListViewModel>
    {
        public int Id { get; set; }
    }
}
