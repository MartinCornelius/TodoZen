using TodoZen.Menu;
using TodoZen.Todo;

namespace TodoZen;

public class Program
{
  public static List<TodoItem> _todos = new List<TodoItem>();
  public static void Main(string[] args)
  {
    TodoItem t1 = new TodoItem("Walk the dog");
    TodoItem t2 = new TodoItem("Go shopping");

    _todos.Add(t1);
    _todos.Add(t2);

    MainMenu menu = new MainMenu("T o d o Z e n");
    menu.Add(new TodosList("1. List todos"));
    menu.Add(new TodoAdd("2. Add todo"));

    menu.Start();
  }
}
