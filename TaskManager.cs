using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();

    public void AddTask(string title)
    {
        tasks.Add(new TaskItem(title));
    }

    public void ShowTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].Title}");
        }
    }
    public void MarkAsDone(int index)
    {
    if (index >= 0 && index < tasks.Count)
    {
        tasks[index].IsDone = true;
    }
}
}
