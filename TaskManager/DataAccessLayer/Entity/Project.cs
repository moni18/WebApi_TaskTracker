using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Commands.Entity
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus projectStatus { get; set; }
        public int Priority { get; set; }
        public IEnumerable<Task> Tasks { get; set; }

    }

    public enum ProjectStatus
    {
        NotStarted,
        Active,
        Completed
    }
}
