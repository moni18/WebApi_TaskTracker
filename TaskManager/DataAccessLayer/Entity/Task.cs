using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.Entity
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus taskStatus { get; set; }
        public int Priority { get; set; }
        public int projectId { get; set; }
        public Project Project { get; set; }
    }

    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }
}
