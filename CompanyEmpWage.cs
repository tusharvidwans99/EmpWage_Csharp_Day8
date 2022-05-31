using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Csharp_Day8
{
    public class CompanyEmpWage
    {

        public int empRatePerHour, numofWorkingDays, maxHoursPerMonth, totalEmpWage;
        public string company;

        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour=empRatePerHour;
            this.numofWorkingDays=numofWorkingDays;
            this.maxHoursPerMonth=maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage=totalEmpWage;
        }

        public string toString()
        {
            string message = $"Total Emp Wage for company: {this.company} is: {this.totalEmpWage}";
            return message;
        }


    }
}
