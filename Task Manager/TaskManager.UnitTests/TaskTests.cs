using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager;

namespace TaskManager.UnitTests
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void StatusIsComplete_Task_ReturnsTrue()
        {
            //Arrange
            var userTask = new Task();

            //Act

            var result = userTask.taskIsComplete(new Task {isComplete = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void StatusIsOverdue_Task_ReturnsTrue()
        {
            //Arrange
            var userTask = new Task();

            //Act

            var result = userTask.taskIsOverdue(new Task { isOverdue = true });

            //Assert
            Assert.IsTrue(result);
        }
    }
}
