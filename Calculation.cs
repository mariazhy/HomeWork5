using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Calculation
    {

        public static int Val = 0;
        List<Task> tasks = new List<Task>();
        Validation validation = new Validation();

        public void CountTotalHoursNecessaryForDoingAllTasks()
        {
            string inputName;
            string inputPriority;
            string inputSeverity;
            int totalHours = 0;
            string validateFinish = "Yes";

            do
            {
                Console.WriteLine("Enter Name of task: ");
                inputName = GetName();//it's necessary to check that it's not empty
                Console.WriteLine("Select Priority of task: ");
                validation.ShowAllPriorities();
                inputPriority = GetPriorityValue();
                Console.WriteLine("Select Severity of task: ");
                validation.ShowAllSeverities();
                inputSeverity = GetSeverityValue();
                //tasks.Add(new Task(inputName, inputPriority, inputSeverity));
                //tasks.ForEach(Console.WriteLine);
                Console.WriteLine("Your task name, priority, severity: " + inputName + " , " + inputPriority + " , " + inputSeverity);
                Console.WriteLine("Do you want add more tasks? Write Yes or No");
                validateFinish = Console.ReadLine();
                switch (inputPriority)
                {
                    case "High":
                        totalHours += (int)EnumPriority.High;
                        break;
                    case "Medium":
                        totalHours += (int)EnumPriority.Medium;
                        break;
                    case "Low":
                        totalHours += (int)EnumPriority.Low;
                        break;
                    default:
                        totalHours += 0;
                        break;
                }
                switch (inputSeverity)
                {
                    case "Simple":
                        totalHours += (int)EnumSeverity.Simple;
                        break;
                    case "Medium":
                        totalHours += (int)EnumSeverity.Medium;
                        break;
                    case "Difficult":
                        totalHours += (int)EnumSeverity.Difficult;
                        break;
                    default:
                        totalHours += 0;
                        break;
                }
                tasks.Add(new Task() { Name = inputName, Priority = inputPriority, Severity = inputSeverity });
                tasks.ForEach(Console.WriteLine);
                Console.WriteLine("Total Hours = " + totalHours);
            } while (validateFinish == "Yes");
            Console.WriteLine("Total Hours = " + totalHours);
        }
        
        private string GetName()
        {
            string inputValue = Console.ReadLine();
           /* if (inputValue == null)
            {
                Console.WriteLine("Your Name is null. Please try again");
            }*/
            return inputValue;
            
        }

        public string GetPriorityValue()
        {
            string inputValue = Console.ReadLine();
            /*if (inputValue == null)
            {
                Console.WriteLine("Your Priority is null. Please try again");
            }
            elsevalidation.ValidatePriority(inputValue);*/
            return inputValue;

            //make Validation here inputPriority = validation.ValidatePriority();
            //return Console.ReadLine();
            //VALIDATE that input is not null
        }

        public string GetSeverityValue()
        {
            string inputValue = Console.ReadLine();
            /*if (inputValue == null)
            {
                Console.WriteLine("Your Priority is null. Please try again");
            }
            else validation.ValidateSeverity(inputValue);*/
            return inputValue;
        }

        public void ShowTasksOfCertainPriority() 
        {
            Console.WriteLine("Enter necessary Priority: High, Medium, Low ");
            string myPriority = Console.ReadLine();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Priority.Equals(myPriority))
                {
                    Console.WriteLine(tasks[i]);
                }
                else Console.WriteLine("No matches");
            }
        }

        public void ShowTasksThatCouldBeDoneForNDays()
        {
            Console.WriteLine("Enter amount of days: ");
            int myDay = int.Parse(Console.ReadLine());
            tasks.Sort(GetPriorityValue);

        }
    }
}
