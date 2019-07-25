using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryItOut.Service;

namespace TryItOut.Tests.ToDoTasks
{
    [TestClass]
    public class ToDoTasksTests
    {
        [TestMethod]
        [Owner("ddm")]
        [TestCategory("ToDoTasks")]
        public void ToDoTasksService_InstanceIsNotNull()
        {
            ToDoTasksService toDo = new ToDoTasksService();

            Assert.IsNotNull(toDo);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("ToDoTasks")]
        public void ToDoTasksService_InstanceIsOfType()
        {
            ToDoTasksService toDo = new ToDoTasksService();

            Assert.IsInstanceOfType(toDo, typeof(ToDoTasksService));
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("ToDoTasks")]
        public void ToDoTasksListDTO_InstanceIsNotNull()
        {
            ToDoTasksListDTO tasksDTO = new ToDoTasksListDTO();

            Assert.IsNotNull(tasksDTO);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("ToDoTasks")]
        public void ToDoTasksListDTO_InitialiseNumberOf()
        {
            ToDoTasksListDTO tasksDTO = new ToDoTasksListDTO();

            Assert.AreEqual(0, tasksDTO.NumberOf);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("ToDoTasks")]
        public void ToDoTasksListDTO_InitialiseIsValid()
        {
            ToDoTasksListDTO tasksDTO = new ToDoTasksListDTO();

            Assert.IsFalse(tasksDTO.IsValid);
        }
    }
}
