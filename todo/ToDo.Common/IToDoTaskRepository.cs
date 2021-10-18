using System;
using System.Collections.Generic;
using ToDo.Model;

namespace ToDo.Common
{
    public interface IToDoTaskRepository
    {
        List<ToDoTask> ListToDos();
        ToDoTask GetToTo(int id);

        ToDoTask AddToDo(string Summary, string Description, DateTime DateDue);

        bool UpdateToDo(int id, string Summary, string Description, DateTime DateDue);

        bool DeleteToDo(int id);

    }
}
