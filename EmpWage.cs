using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Csharp_Day8
{
    public class EmpWage
    {
        /// <summary>
        /// This program is used to check whether employee is present or absent
        /// </summary>


        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int MAX_WORK_DAYS = 20;
        const int MAX_WORK_HOURS = 100;
        const int EMP_WAGE_PER_HOUR = 20;

        public void empcheck()
        {

            int total_EmpWage = 0;
            int Emp_Daily_hour;
            int days = 0, total_hours = 0;
            Random r = new Random();

            while (days < MAX_WORK_DAYS || MAX_WORK_HOURS <= total_hours)
            {
                days++;
                int check = r.Next(3);

                switch (check)
                {
                    case IS_FULL_TIME:
                        Emp_Daily_hour = 8;
                        break;
                    case IS_PART_TIME:
                        Emp_Daily_hour = 4;
                        break;
                    default:
                        Emp_Daily_hour = 0;
                        break;
                }

                total_hours += Emp_Daily_hour;
                int DailyWage = EMP_WAGE_PER_HOUR * Emp_Daily_hour;
                Console.WriteLine($"Day{days}: {DailyWage}");
                total_EmpWage += DailyWage;

            }
            Console.WriteLine($"Total Wage :{total_EmpWage}");
            Console.WriteLine($"Days Completed: {days} \nTotal hours Completed: {total_hours}");
        }

    }
}