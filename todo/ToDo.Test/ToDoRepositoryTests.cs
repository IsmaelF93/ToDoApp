using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDo.Repository;

namespace ToDo.Test
{
    [TestClass]
    public class ToDoRepositoryTests
    {
        [TestMethod]
        public void TestList()
        {
            var toDoRepository = new ToDoTaskRepository();

            toDoRepository.AddToDo("Test Summary", "Test Description", DateTime.Now.AddDays(10));

            Assert.IsTrue(toDoRepository.ListToDos()?.Count > 0);
        }

        [TestMethod]
        public void TestUpdate()
        {
            var toDoRepository = new ToDoTaskRepository();

            toDoRepository.AddToDo("Test Summary", "Test Description", DateTime.Now.AddDays(10));

            toDoRepository.UpdateToDo(1, "This has been updated", "Updated description", DateTime.Now.AddDays(10));

            var findTaskSummary = toDoRepository.GetToTo(1);
            string summaryString = findTaskSummary.Summary;

            string constantString = "This has been updated";

            Assert.AreEqual(summaryString, constantString );
        }
    }
}
