using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Validation;
//using TaskManagerModel;

namespace TaskDL
{
    class TaskManagerContextInitializer:DropCreateDatabaseIfModelChanges<TaskManagerContext>
    {
        public override void InitializeDatabase(TaskManagerContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}
