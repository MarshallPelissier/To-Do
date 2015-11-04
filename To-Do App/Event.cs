using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_App
{
    public class Event
    {
        public Event(bool done, bool due_date, DateTime created, DateTime completed, DateTime due, string title, string description, float completion, Project assigned_project)
        {
            Done = done;
            Due_Date = due_date;
            Created = created;
            Completed = completed;
            Due = due;
            Title = title;
            Description = description;
            Completion = completion;
            Assigned_Project = assigned_project;
        }

        public bool Done { get; set; }
        public bool Due_Date { get; set; }
        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }
        public DateTime Due { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public float Completion { get; set; }
        public Project Assigned_Project { get; set; }
    }
}
