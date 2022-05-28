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
        public void empcheck()
        {

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            int EMP_WAGE_PER_HOUR = 20;
            int Emp_Daily_hour;
            Random r = new Random();

            int check = r.Next(3);

            switch (check)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Present");
                    Emp_Daily_hour = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Part time");
                    Emp_Daily_hour = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    Emp_Daily_hour = 0;
                    break;
            }


            int DailyWage = EMP_WAGE_PER_HOUR * Emp_Daily_hour;
            Console.WriteLine($"Emp daily wage is: {DailyWage}");
        }

    }
}