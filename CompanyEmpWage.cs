using System;

public class CompanyEmpWage
{

    private string company;
    //private int empRatePerHour;
    //private int numOfWorkingDays;
    //private int maxHoursPerMonth;
    public int empRatePerHour;
    public int numOfWorkingDays;
    public int maxHoursPerMonth;
    private int totalEmpWage;

    public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }

    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }
    public string toString()
    {
        return "Total Emp Wage for Company : " + this.company + " is : " + this.totalEmpWage;
    }
}
