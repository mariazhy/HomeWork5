﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.CountTotalHoursNecessaryForDoingAllTasks();
            calculation.ShowTasksOfCertainPriority();
            calculation.ShowTasksThatCouldBeDoneForNDays();
        }
    }
}
