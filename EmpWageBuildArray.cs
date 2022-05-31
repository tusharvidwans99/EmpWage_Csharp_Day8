using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Csharp_Day8
{
    public class EmpWageBuildArray : IComputeEmpWage
    {
        /// <summary>
        /// This program is used to check whether employee is present or absent
        /// </summary>


        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numofCompany = 0;

        private CompanyEmpWage[] companyEmpWageArray;

        public string companyName;
        
        public EmpWageBuildArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }

        
        public void computeEmpWage()
        {
            for(int i=0; i < numofCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            Random r = new Random();

            while (totalEmpHrs<=companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numofWorkingDays)
            {
                totalWorkingDays++;

                int check = r.Next(3);

                switch (check)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine($"Day: {totalWorkingDays}  Emp Hrs: {empHrs}");
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}