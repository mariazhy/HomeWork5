using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Validation
    {
        public string inputTaskName;
        public string inputPriorityName;
        public string inputSeverityName;
        public int inputPriorityValue;
        public int inputSeverityValue;

        public void ShowAllPriorities()
        {
            foreach (string priority in Enum.GetNames(typeof(EnumPriority)))
            {
                Console.WriteLine(priority);
            }

        }

        public void ShowAllSeverities()
        {
            foreach (string severity in Enum.GetNames(typeof(EnumSeverity)))
            {
                Console.WriteLine(severity);
            }

        }

        public string GetName()
        {
            do
            {
                Console.WriteLine("Please enter task name: ");
                string inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    Console.WriteLine("Your task name is invalid");
                }
                inputTaskName = inputValue;
            } while (string.IsNullOrEmpty(inputTaskName));
            return inputTaskName;
        }

        public string GetPriorityValue()
        {
            do
            {
                string inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    Console.WriteLine("Your Priority is NULL. Please try again");

                }
                inputPriorityName = inputValue;
            } while (string.IsNullOrEmpty(inputPriorityName));
            return inputPriorityName.First().ToString().ToUpper() + inputPriorityName.Substring(1);
        }

        public string GetSeverityValue()
        {
            do
            {
                string inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    Console.WriteLine("Your Severity is NULL. Please try again");
                }
                inputSeverityName = inputValue;
            } while (string.IsNullOrEmpty(inputSeverityName));
            return inputSeverityName.First().ToString().ToUpper() + inputSeverityName.Substring(1);
        }

        public string ValidatePriority()
        {
            Console.WriteLine("Enter Priority:");
            string value = GetPriorityValue();
            string[] arrayPriority = Enum.GetNames(typeof(EnumPriority));

            do
            {
                bool has = arrayPriority.Contains(value);
                if (has)
                {
                    inputPriorityName = value;
                }
                else
                {
                    Console.WriteLine("Invalid. Please select priority from the list:");
                    ShowAllPriorities();
                    value = GetPriorityValue();

                }
            } while (value.Equals(EnumPriority.High) || value.Equals(EnumPriority.Medium) || value.Equals(EnumPriority.Low));
            return inputPriorityName;

        }

        public string ValidateSeverity()
        {
            Console.WriteLine("Enter Severity:");
            string value = GetSeverityValue();
            string[] arraySeverity = Enum.GetNames(typeof(EnumSeverity));

            do
            {
                bool has = arraySeverity.Contains(value);
                if (has)
                {
                    inputSeverityName = value;
                }
                else
                {
                    Console.WriteLine("Invalid. Please select severity from the list:");
                    ShowAllSeverities();
                    value = GetSeverityValue();

                }
            } while (value.Equals(EnumSeverity.Difficult) || value.Equals(EnumSeverity.Medium) || value.Equals(EnumSeverity.Simple));
            return inputSeverityName;
        }

    }
}
