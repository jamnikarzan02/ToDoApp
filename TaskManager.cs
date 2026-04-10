using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();
    private string filePath = "tasks.json";

    public TaskManager()
    {
        LoadTasks();
    }

    public void AddTask(string title)
    {
        tasks.Add(new TaskItem(title));
    }

    public void ShowTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(tasks[i].IsDone ? "X" : " ")}] {tasks[i].Title}");
        }
    }

    public void SaveTasks()
    {
        var json = JsonSerializer.Serialize(tasks);
        File.WriteAllText(filePath, json);
    }

    public void LoadTasks()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
    }
}
