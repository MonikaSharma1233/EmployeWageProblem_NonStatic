// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
using System.Xml.Schema;

namespace EmployeeWageProblem;
class Program
{

    public static void Main(String[] args)
    {
        EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
        //string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth
        empWageBuilderArray.addCompanyEmpWage("DMart", 20, 15, 10);
        empWageBuilderArray.addCompanyEmpWage("Relaince", 10, 10, 20);
        empWageBuilderArray.addCompanyEmpWage("Airtel", 40, 20, 100);
        empWageBuilderArray.computeEmpWage();
        Console.WriteLine("Total Wage of DMart Company: " + empWageBuilderArray.getTototalWage("DMart"));
        Console.WriteLine("Total Wage of Relaince Company: " + empWageBuilderArray.getTototalWage("Relaince"));
        Console.WriteLine("Total Wage of Airtel Company: " + empWageBuilderArray.getTototalWage("Airtel"));


        Console.ReadKey();
    }


}


