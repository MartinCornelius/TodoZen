using TodoZen.Data;
using TodoZen.Menu;

namespace TodoZen.Todo;

public class TodosList : MenuItem
{
  public TodosList(string content) : base(content)
  {
  }

  public override void Select()
  {
    TodosList _menu = new TodosList("List of all todos");

    FileContext fc = new FileContext();
    Program._todos = fc.GetAllTodos();

    foreach (TodoItem todo in Program._todos)
    {
      _menu.Add(todo);
    }

    _menu.Start();
  }

  public override void DrawMenu()
  {
    Console.Clear();
    PrintTitle();

    foreach (TodoItem todo in Program._todos)
    {
      Helper.ResetColor();

      if (todo.Highlighted)
        Helper.SetBackgroundColor(ConsoleColor.Green);

      Helper.WriteToCenter($"{(todo.Done == true ? "[x]" : "[ ]")} {todo.Content}");
    }
  }
}