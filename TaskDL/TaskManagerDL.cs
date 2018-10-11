using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerModel;
using System.Data.Entity;

namespace TaskDL
{
    public class TaskManagerDL
    {
        private TaskManagerContext tmContext = new TaskManagerContext();

        private bool TableTaskExists(int id)
        {
            return tmContext.TaskTableData.Count(e => e.Task_ID == id) > 0;
        }

        public void AddTask(TaskTableData taskData)
        {           
            tmContext.TaskTableData.Add(taskData);
            tmContext.SaveChanges();            
        }

        public List<TaskTableData> GetTasks()
        {            
            return tmContext.TaskTableData.ToList();
        }

        public TaskTableData GetTask(int id)
        {            
            return tmContext.TaskTableData.Find(id);
        }

        public void UpdateTask(int id, TaskTableData taskData)
        {
            if (TableTaskExists(id))
            {
                tmContext.Entry(taskData).State = EntityState.Modified;
                tmContext.SaveChanges();
            }            
        }

        public void DeleteTask(int id)
        {
            TaskTableData tableTask = tmContext.TaskTableData.Find(id);

            if (tableTask != null)
            {
                tmContext.TaskTableData.Remove(tableTask);
                tmContext.SaveChanges();
            }
        }
    }
}
