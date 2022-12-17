using ApplicationLayer.Projects.Commands.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommand : IRequest
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public ProjectStatus projectStatus { get; set; }
    }
}
