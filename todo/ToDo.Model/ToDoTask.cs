using System;

namespace ToDo.Model
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateCompleted { get; set; }

        public ToDoTask()
        {
            DateCreated = DateTime.Now;
        }
    }
}
