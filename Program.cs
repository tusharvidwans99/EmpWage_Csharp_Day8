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
            EmpWage Apple = new EmpWage(20, 150, 40, "Apple");
            EmpWage Microsoft = new EmpWage(20, 140, 38, "Microsoft");
            EmpWage Google = new EmpWage(18, 145, 42, "Google");

            
        }

    }
}