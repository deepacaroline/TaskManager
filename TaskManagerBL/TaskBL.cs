using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDL;
using TaskManagerModel;

namespace TaskManagerBL
{
    public class TaskBL
    {
        TaskManagerDL tmDL = new TaskManagerDL();

        public void AddTask(TaskTableData taskData)
        {
            tmDL.AddTask(taskData);
        }

        public List<TaskTableData> GetTasks()
        {
            return tmDL.GetTasks();
        }

        public TaskTableData GetTask(int id)
        {
            return tmDL.GetTask(id);
        }

        public void UpdateTask(int id, TaskTableData taskData)
        {
            tmDL.UpdateTask(id, taskData);
        }

        public void DeleteTask(int id)
        {
            tmDL.DeleteTask(id);
        }
    }
}
