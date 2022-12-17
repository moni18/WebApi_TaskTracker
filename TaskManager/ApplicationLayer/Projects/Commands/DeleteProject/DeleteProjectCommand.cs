using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.DeleteProject
{
    public class DeleteProjectCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
