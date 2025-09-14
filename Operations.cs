using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    // Модель задачи
    public class Tasks
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public int Priority { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DateTime { get; set; } = string.Empty;
    }

    // Контекст базы данных
    public class Context : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ToDoApp.db");
    }

    // Операции с задачами (адаптировано для GUI)
    public class Operations
    {
        private readonly Context db;

        public Operations(Context context)
        {
            db = context;
        }

        public List<Tasks> GetAllTasks()
        {
            return db.Tasks.ToList();
        }

        public List<Tasks> GetTasksByDueDate()
        {
            return db.Tasks.OrderBy(t => t.DateTime).ToList();
        }

        public List<Tasks> GetTasksByPriority()
        {
            return db.Tasks.OrderBy(t => t.Priority).ToList();
        }

        public void AddTask(string category, int priority, string description, string dateTime)
        {
            var task = new Tasks
            {
                Category = category,
                Priority = priority,
                Description = description,
                DateTime = dateTime
            };
            db.Tasks.Add(task);
            SaveChanges();
        }

        public void RemoveTask(int taskId)
        {
            var task = db.Tasks.Find(taskId);
            if (task != null)
            {
                db.Tasks.Remove(task);
                SaveChanges();
            }
        }

        public void UpdateTask(int taskId, string category, int priority, string description, string dateTime)
        {
            var task = db.Tasks.Find(taskId);
            if (task != null)
            {
                task.Category = category;
                task.Priority = priority;
                task.Description = description;
                task.DateTime = dateTime;
                db.Tasks.Update(task);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при сохранении: " + ex.Message);
            }
        }

        public List<Tasks> SearchByCategory(string category)
        {
            return db.Tasks.Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Tasks> SearchByPriority(int priority)
        {
            return db.Tasks.Where(t => t.Priority == priority).ToList();
        }
    }
}
