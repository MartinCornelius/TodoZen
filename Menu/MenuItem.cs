namespace TodoZen.Menu;

public class MenuItem : MainMenu
{
  public bool Highlighted { get; set; } = false;

  public MenuItem(string title) : base(title)
  {
    this.Title = title;
  }


  public virtual void Select()
  {
    Console.Clear();
    Helper.WriteToCenter(this.Title);

    Console.WriteLine("Press any key to go back to menu...");
    Console.ReadKey();
  }
}
