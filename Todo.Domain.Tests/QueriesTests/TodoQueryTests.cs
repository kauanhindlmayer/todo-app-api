using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueriesTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "Usuário A", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "andrebaltieri", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "Usuário B", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "Usuário C", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "andrebaltieri", DateTime.Now));
        }

        [TestMethod]
        public void ShouldReturnUserTodosWhenQuery()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("andrebaltieri"));
            Assert.AreEqual(2, result.Count());
        }
    }
}
