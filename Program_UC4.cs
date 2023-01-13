// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
namespace EmployeeWageProblem;
class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public static void Main(String[] args)
    {
        //Constants

        Random random = new Random();
        //Variables
        int empHrs = 0;
        int empWage = 0;
        //Computation
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
                break; empHrs = 0;
        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : " + empWage);


        Console.ReadKey();
    }
}


