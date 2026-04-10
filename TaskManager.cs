using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
private string filePath = "tasks.json";

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
            Console.WriteLine($"{i + 1}. [{(tasks[i].IsDone ? "X" : " ")}] {tasks[i].Title}");;
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
