using System;

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();

        while (true)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Exit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter task: ");
                    string title = Console.ReadLine();
                    manager.AddTask(title);
                    break;

                case "2":
                    manager.ShowTasks();
                    break;
                    
                case "3":
                    Console.Write("Enter task number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.MarkAsDone(index);
                    break;

                case "4":
                    return;
                    
            }
        }
    }
}
