// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
using System.Xml.Schema;

namespace EmployeeWageProblem;
class Program
{
    //Constants
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 20;
    public const int MAX_HRS_IN_MONTH = 100;
    public static int ComputeEmpWage(string company, int empRatePerHour, int bynOfWorkingDays, int maxHoursPerMonth)
    {
        //Variables
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        //Computation
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            totalEmpHrs += empHrs;
            Console.WriteLine("Days  : " + totalWorkingDays + "Emp Hrs : " + totalEmpHrs);
        }
        totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        Console.WriteLine("Total Emp Wage for Company : " + company + " is : " + totalEmpWage);
        return totalEmpWage;
    }
    public static void Main(String[] args)
    {

        ComputeEmpWage("DMrt", 20, 2, 10);
        ComputeEmpWage("Reliance", 10, 4, 20);



        Console.ReadKey();
    }


}


