using TodoZen.Menu;
using TodoZen.Data;

namespace TodoZen.Todo;

public class TodoAdd : MenuItem
{
  public TodoAdd(string content) : base(content)
  {
  }

  public override void Select()
  {
    Console.Clear();
    Helper.WriteToCenter(this.Title);

    Console.Write("Enter todo: ");
    string _todoContent = Console.ReadLine()!;

    // Program._todos.Add(new TodoItem(_todoContent));
    FileContext fc = new FileContext();
    fc.AddTodo(new TodoItem(_todoContent));
  }
}