using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_App
{
    public class Project
    {
        public Project(bool done, bool due_date, DateTime created, DateTime completed, DateTime due,string title, string description)
        {
            Done = done;
            Due_Date = due_date;
            Created = created;
            Completed = completed;
            Due = due;
            Title = title;
            Description = description;
        }

        public void Add_Events(Event events)
        {
            All_Events.Add(events);
        }

        public void Delete_Event(Event events)
        {
            All_Events.Remove(events);
        }

        public bool Done { get; set; }
        public bool Due_Date { get; set; }
        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }
        public DateTime Due { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public float Completion { get; set; }
        public List<Event> All_Events = new List<Event>();
    }
}
