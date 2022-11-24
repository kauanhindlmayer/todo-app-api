using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Título da tarefa", "Nome do usuário", DateTime.Now);

        [TestMethod]
        public void ShouldNotBeDoneWhenNewTodoIsCreated()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }

    }
}
