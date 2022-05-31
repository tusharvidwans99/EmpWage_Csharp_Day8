namespace EmpWage_Csharp_Day8
{
    public class Program
    {
        /// <summary>
        /// Greeting message to welcome in this program.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            
            
            IComputeEmpWage empWageBuildArray = new EmpWageBuildArray();

            empWageBuildArray.addCompanyEmpWage("Apple", 35, 15, 100);
            empWageBuildArray.addCompanyEmpWage("Microsoft", 33, 17, 90);
            empWageBuildArray.addCompanyEmpWage("Google", 50, 18, 110);
            empWageBuildArray.addCompanyEmpWage("Accenture", 15, 20, 120);
            empWageBuildArray.addCompanyEmpWage("TCS", 15, 25, 130);
            empWageBuildArray.computeEmpWage();

        }

    }
}