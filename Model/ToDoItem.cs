namespace Eisenhower_Matrix.Model;

public class ToDoItem
{
    public string Title { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsImportant { get; set; } = false;
    public bool IsDone { get; set; } = false;
    public char ItemMark { get; set; }

    public ToDoItem(string title, DateTime deadline)
    {
        Title = title;
        Deadline = deadline;
    }

    public string CreateToDoItem(string title, DateTime deadline)
    {
        Title = title;
        Deadline = deadline;
        return ToString();
    }

    public void MakeImportant()
    {
        IsImportant = true;
    }
    public void Mark()
    {
        IsDone = true;
    }

    public void Unmark()
    {
        IsDone = false;
    }

    public override string ToString()
    {
        ItemMark = IsDone ? 'x' : ' ';
        return $"[{ItemMark}] {Deadline.Month}-{Deadline.Day} {Title}";
    }


}