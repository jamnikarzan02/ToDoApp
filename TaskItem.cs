public class TaskItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public TaskItem(string title)
    {
        Title = title;
        IsDone = false;
    }
}
