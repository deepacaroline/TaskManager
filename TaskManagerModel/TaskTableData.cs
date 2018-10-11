using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerModel
{
    public class TaskTableData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()]
        public int Task_ID { get; set; }
        public int Parent_ID { get; set; }
        public string Task { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }
        
    }
}
