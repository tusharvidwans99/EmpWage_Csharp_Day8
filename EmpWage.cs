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

            int isFullTime = 1;
            int EMP_WAGE_PER_HOUR = 20;
            int Emp_Daily_hour;
            Random r = new Random();

            int check = r.Next(2);

            if (check == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                Emp_Daily_hour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Emp_Daily_hour = 0;
            }

            int DailyWage = EMP_WAGE_PER_HOUR * Emp_Daily_hour;
            Console.WriteLine($"Emp daily wage is: {DailyWage}");
        }

    }
}