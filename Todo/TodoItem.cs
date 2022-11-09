using TodoZen.Menu;
using TodoZen.Data;

namespace TodoZen.Todo;

public class TodoItem : MenuItem
{
  public string Content { get; set; }
  public bool Done { get; set; } = false;

  public TodoItem(string content) : base(content)
  {
    this.Content = content;
  }

  public override void Select()
  {
    FileContext fc = new FileContext();
    if (this.Done == true)
    {
      this.Done = false;
    }
    else
    {
      this.Done = true;
    }
    fc.UpdateTodos(this);
  }
}
