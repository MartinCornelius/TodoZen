using TodoZen.Todo;

namespace TodoZen.Data;

public class FileContext
{
  private string PathToFile;

  public FileContext()
  {
    this.PathToFile = "Data/todos.dat";
  }

  public List<TodoItem> GetAllTodos()
  {
    List<TodoItem> todos = new List<TodoItem>();
    using FileStream fs = new FileStream(PathToFile, FileMode.Open);
    using StreamReader sr = new StreamReader(fs);

    string line;
    while ((line = sr.ReadLine()) != null)
    {
      string[] parameters = line.Split("|");
      TodoItem todo = new TodoItem(parameters[1])
      {
        Done = parameters[0] == "True" ? true : false
      };
      todos.Add(todo);
    }

    return todos;
  }

  public void AddTodo(TodoItem todo)
  {
    using FileStream fs = new FileStream(PathToFile, FileMode.Append);
    using StreamWriter sw = new StreamWriter(fs);

    sw.WriteLine($"{todo.Done}|{todo.Content}");
  }
}