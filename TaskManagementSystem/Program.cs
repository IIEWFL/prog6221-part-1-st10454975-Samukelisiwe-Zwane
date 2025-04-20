using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    //Define a delegate to notify when a task is added.
    public delegate void TaskAddedEventHandler(string taskName);

    class TaskManager
    {
        private ArrayList tasks;

        //Define an event based on the delegate.
        public event TaskAddedEventHandler TaskAdded;

        public TaskManager()
        {
            //  Use ArrayList to store task names.
            tasks = new ArrayList();
        }

        public void AddTask(string taskName)
        {
            tasks.Add(taskName);
            Console.WriteLine($"Task '{taskName}' added.");

            //Raise the event to notify subscribers.
            TaskAdded?.Invoke(taskName);
        }

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            Console.WriteLine("Current Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"- {tasks[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            // Use an anonymous method to log to the console when a task is added.
            taskManager.TaskAdded += delegate (string taskName)
            {
                Console.WriteLine($"[LOG] Task '{taskName}' was added at {DateTime.Now}.");
            };

            taskManager.AddTask("Buy groceries");
            taskManager.AddTask("Finish report");
            taskManager.ListTasks();

            Console.ReadKey();
        }
    }
}
