using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ToDoListAppWithGUI.Models;

namespace ToDoListAppWithGUI.Services
{
    public class TaskManager
    {
        public List<ToDoListAppWithGUI.Models.Task> Tasks { get; private set; }
        private readonly string filePath = "tasks.json";

        public TaskManager()
        {
            Tasks = LoadTasksFromFile();
        }

        public void AddTask(string description)
        {
            int newId = Tasks.Count > 0 ? Tasks[^1].Id + 1 : 1;
            Tasks.Add(new ToDoListAppWithGUI.Models.Task(newId, description));
        }

        public void EditTask(int id, string newDescription)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.Description = newDescription;
            }
        }

        public void CompleteTask(int id)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
        }

        public void DeleteTask(int id)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }

        public void SaveTasksToFile()
        {
            string json = JsonSerializer.Serialize(Tasks);
            File.WriteAllText(filePath, json);
        }

        private List<ToDoListAppWithGUI.Models.Task> LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<ToDoListAppWithGUI.Models.Task>>(json) ?? new List<ToDoListAppWithGUI.Models.Task>();
            }
            return new List<ToDoListAppWithGUI.Models.Task>();
        }
    }
}
