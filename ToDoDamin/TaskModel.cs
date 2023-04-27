using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoDamin
{
    public class TaskModel
    {
        public string Dates { get; }
        public string Description { get; }

        public TaskModel(DateTime startDate, DateTime endDate, string description) 
        {
            Dates = $"{startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}";
            Description = description;
        }
    }
}
