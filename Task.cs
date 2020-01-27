using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Task
    {
        //private int id;
        public string Name { get; set; }

        public string Priority { get; set; }
        public string Severity { get; set; }
        public int PriorityValue { get; set; }
        public int SeverityValue { get; set; }
        
        public Task(string name, string priority, string severity, int priorityValue, int severityValue)
        {
            Name = name;
            Priority = priority;
            Severity = severity;
            SeverityValue = severityValue;
            PriorityValue = priorityValue;
        }

        public Task()
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + "   Priority: " + Priority + "   Severity: " + Severity + "   PriorityValue: " + PriorityValue + "   SeverityValue: " + SeverityValue;
        }
    }
}
