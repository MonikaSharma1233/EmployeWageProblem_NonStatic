// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
namespace EmployeeWageProblem;
class Program
{
    public static void Main(String[] args)
    {
        //Constants
        int IS_FULL_TIME = 1;
        Random random = new Random();
        //Computation
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present");

        }
        else
        {
            Console.WriteLine("Employee is Absend");
        }


        Console.ReadKey();
    }
}


