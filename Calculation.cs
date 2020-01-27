using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Calculation
    {

        public int totalHours;
        List<Task> tasks = new List<Task>();
        Validation validation = new Validation();
        List<Task> selectedTasks;
        public void CountTotalHoursNecessaryForDoingAllTasks()
        {
            string inputName;
            string inputPriority;
            string inputSeverity;
            int valuePriority;
            int valueSeverity;
            string validateFinish = "Yes";
            do
            {
                inputName = validation.GetName();
                inputPriority = validation.ValidatePriority();
                inputSeverity = validation.ValidateSeverity();
                Console.WriteLine("Your task name, priority, severity: " + inputName + " , " + inputPriority + " , " + inputSeverity);
                switch (inputPriority)
                {
                    case "High":
                        valuePriority = (int)EnumPriority.High;
                        break;
                    case "Medium":
                        valuePriority = (int)EnumPriority.Medium;
                        break;
                    case "Low":
                        valuePriority = (int)EnumPriority.Low;
                        break;
                    default:
                        valuePriority = 0;
                        break;
                }
                switch (inputSeverity)
                {
                    case "Simple":
                        totalHours += (int)EnumSeverity.Simple;
                        valueSeverity = (int)EnumSeverity.Simple;
                        break;
                    case "Medium":
                        totalHours += (int)EnumSeverity.Medium;
                        valueSeverity = (int)EnumSeverity.Medium;
                        break;
                    case "Difficult":
                        totalHours += (int)EnumSeverity.Difficult;
                        valueSeverity = (int)EnumSeverity.Difficult;
                        break;
                    default:
                        totalHours += 0;
                        valueSeverity = 0;
                        break;
                }
                tasks.Add(new Task()
                {
                    Name = inputName,
                    Priority = inputPriority, 
                    Severity = inputSeverity, 
                    PriorityValue = valuePriority, 
                    SeverityValue = valueSeverity 
                });
                Console.WriteLine("Do you want to add more tasks? Write Yes or No");
                validateFinish = Console.ReadLine();
                Console.WriteLine("Total Hours = " + totalHours);
             } while (validateFinish == "Yes" || validateFinish == "yes");
            tasks = tasks.OrderBy(x => x.PriorityValue)
                .ThenBy(x => x.SeverityValue).ToList();
            Console.WriteLine("Your tasks are next: ");
            tasks.ForEach(Console.WriteLine);
            Console.WriteLine("Total Hours = " + totalHours);
        }
        
        public void ShowTasksOfCertainPriority() 
        {
            Console.WriteLine("Enter necessary Priority: High, Medium, Low ");
            string myPriority = Console.ReadLine();
            selectedTasks = tasks.Where(x => x.Priority == myPriority.First().ToString().ToUpper() + myPriority.Substring(1)).ToList();
            if(selectedTasks.Count > 0)
                selectedTasks.ForEach(Console.WriteLine);
            else
                Console.WriteLine("No matches");
        }

        public void ShowTasksThatCouldBeDoneForNDays()
        {
            Console.WriteLine("Enter amount of days: ");
            int inputHours = int.Parse(Console.ReadLine()) * 8;
            int result = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (result + tasks[i].SeverityValue <= inputHours)
                {
                    result += tasks[i].SeverityValue;
                    Console.WriteLine(tasks[i]);
                }
                else 
                {
                    break;
                }
            }  
        }
    }
}
