// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
namespace EmployeeWageProblem;
class Program
{
    public static void Main(String[] args)
    {
        //Constants
        int IS_PART_TIME = 1;
        int IS_FULL_TIME = 2;
        int EMP_RATE_PER_HOUR = 20;
        Random random = new Random();
        //Variables
        int empHrs = 0;
        int empWage = 0;
        //Computation
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_PART_TIME)
        {
            empHrs = 4; ;
        }
        else if (empCheck == IS_FULL_TIME)
        {
            empHrs = 8;

        }
        else
        {
            empHrs = 0;
        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : " + empWage);


        Console.ReadKey();
    }
}


