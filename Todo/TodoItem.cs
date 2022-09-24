using TodoZen.Menu;

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
    if (this.Done == true)
    {
      this.Done = false;
    }
    else
    {
      this.Done = true;
    }
  }
}