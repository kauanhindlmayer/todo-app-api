using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void ShouldNotCreateTodoWhenCommandIsInvalid()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void ShouldCreateTodoWhenCommandIsValid()
        {
            var command = new CreateTodoCommand("Título da tarefa", "Nome do usuário", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, true);
        }
    }
}