using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Validation
    {
        public void ShowAllPriorities() 
        {
            foreach (string priority in Enum.GetNames(typeof(EnumPriority)))
            {
                Console.Write("{0} ", priority);
            }
            
        }
        public void ShowAllSeverities() 
        {
            foreach(string severity in Enum.GetNames(typeof(EnumSeverity)))
            {
                Console.Write("{0} ", severity);
            }
            
        }
        public string ValidatePriority(string value) 
        {
            
            //string value = Console.ReadLine();
            foreach (string priority in Enum.GetNames(typeof(EnumPriority)))
            {
                if (value.ToLower() == priority.ToLower())
                {
                    return priority;
                }
                else Console.WriteLine($"Entered value is invalid. Please select priority from the list: ");
                ShowAllPriorities();
                continue;
            }
            return value;
        }
        public string ValidateSeverity(string value)
        {
            //string value = Console.ReadLine();
            foreach (string severity in Enum.GetNames(typeof(EnumSeverity)))
            {
                if (value.ToLower() != severity.ToLower())
                {
                    Console.WriteLine("Entered value is invalid. Please select severity from the list: ");
                    ShowAllSeverities();
                    continue;
                }
                else return severity;

            }
            return value;
        }

    }
}
