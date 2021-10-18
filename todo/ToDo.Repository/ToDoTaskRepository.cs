using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Common;
using ToDo.Model;

namespace ToDo.Repository
{
    public class ToDoTaskRepository : IToDoTaskRepository
    {
        private static List<ToDoTask> _internalList = new List<ToDoTask>();
        
        public ToDoTask AddToDo(string Summary, string Description, DateTime DateDue)
        {
            var newToDoTask = new ToDoTask() {Summary = Summary, Description = Description, DateDue = DateDue };

            newToDoTask.Id = _internalList.Max( t => t.Id) + 1;

            return newToDoTask;
        }

        public bool DeleteToDo(int id)
        {
            var returnValue = false;
            
            var todoToDelete = _internalList.Where(t => t.Id == id).FirstOrDefault();

            if (todoToDelete != null)
            {
                _internalList.Remove(todoToDelete);
                returnValue = true;
            }

            return returnValue;
        }

        public ToDoTask GetToTo(int id)
        {
            return _internalList.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<ToDoTask> ListToDos()
        {
            return _internalList;
        }

        public bool UpdateToDo(int id, string Summary, string Description, DateTime DateDue)
        {
            var returnValue = false;

            var todoToUpdate = _internalList.Where(t => t.Id == id).FirstOrDefault();            

            if (todoToUpdate != null)
            {
                todoToUpdate.Summary = Summary;
                todoToUpdate.Description = Description;
                todoToUpdate.DateDue = DateDue;

                returnValue = true;
            }

            return returnValue;

        }
    }
}
