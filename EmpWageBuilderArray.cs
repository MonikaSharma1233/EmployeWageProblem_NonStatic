using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmpWageBuilderArray : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        //private CompanyEmpWage[] companyEmpWageArray;//create an array with data type companyempwage datatype

        public EmpWageBuilderArray()//constructor
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        //method of empwagebuilderarray

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.AddLast(companyEmpWage);
            companyToEmpWageMap.Add(company, companyEmpWage);
            //throw new NotImplementedException();
        }
        //method overloading
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;

            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }



        public int getTototalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
            //  throw new NotImplementedException();
        }
    }
}
