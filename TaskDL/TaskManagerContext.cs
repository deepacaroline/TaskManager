using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Validation;
using TaskManagerModel;

namespace TaskDL
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext()
        {
            Database.SetInitializer(new TaskManagerContextInitializer());
        }
        public DbSet<TaskTableData> TaskTableData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskTableData>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
