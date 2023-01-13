// See https://aka.ms/new-console-template for more information
//using EmployeeWageProblem;
using System.Xml.Schema;

namespace EmployeeWageProblem;
class Program
{

    public static void Main(String[] args)
    {
        EmpWageBuilderObject dmart = new EmpWageBuilderObject("DMart", 20, 2, 10);
        EmpWageBuilderObject rel = new EmpWageBuilderObject("Reliance", 10, 4, 20);
        dmart.computeEmpWage();
        Console.WriteLine(dmart.toString());
        rel.computeEmpWage();
        Console.WriteLine(rel.toString());





        Console.ReadKey();
    }


}


