using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        class TaskItem
        {
            public string Description;
            public bool IsCompleted;

            public TaskItem(string description)
            {
                if (string.IsNullOrWhiteSpace(description))
                {
                    Console.WriteLine("Description cannot be empty.");
                }
                else
                {
                    Description = description;
                    IsCompleted = false;
                }
            }

        }
        class ToDoList
        {
            private List<TaskItem> TaskItem = new List<TaskItem>();

            public void AddTask(string description)
            {
                TaskItem.Add(new TaskItem(description));
            }
            public void ViewAllTasks()
            {
                for (int i = 0; i < TaskItem.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {TaskItem[i].Description} - {(TaskItem[i].IsCompleted ? "Completed" : "Pending")}");
                }
            }
            public void MarkTaskAsCompleted(int index)
            {
                if (index < 0 || index >= TaskItem.Count)
                {
                    Console.WriteLine("Invalid index.");
                }
                else
                {
                    TaskItem[index].IsCompleted = true;
                    Console.WriteLine("Task marked as completed!");
                }
            }
            public void RemoveTask(int index)
            {
                if (index < 0 || index >= TaskItem.Count)
                {
                    Console.WriteLine("Invalid index.");
                }
                else
                    TaskItem.RemoveAt(index);
            }

        }
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();
            while (true) {
                Console.WriteLine("To-Do List Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Remove Task");
                Console.WriteLine("5. Save and Exit");
                Console.Write("Select an option ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        list1.AddTask(description);
                        break;
                    case "2":
                        list1.ViewAllTasks();
                        break;
                    case "3":
                        Console.Write("Enter task index to mark as completed: ");
                        int indexToComplete = int.Parse(Console.ReadLine()) - 1;
                        list1.MarkTaskAsCompleted(indexToComplete);
                        break;
                    case "4":
                        Console.Write("Enter task index to remove: ");
                        int indexToRemove = int.Parse(Console.ReadLine()) - 1;
                        list1.RemoveTask(indexToRemove);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
