using System;

namespace CSharpAssignmentDay3
{
   public class EmployeeWage
   {
       //constants
          public const int partTimeHrs=1;
          public const int FullTimeHrs=2;
          public const int wagePerHour=20;
          public const int workingDayPerMonth = 2;
          public const int maxHrsPerMonth = 10;
          
 		public static int EmployeeWageSolution()
		{
          //variables
          int totalEmpHrs=0, empHrs=0, totalWorkingDays=0;
          while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays<=workingDayPerMonth)
          {
                totalWorkingDays++;
                  Random random = new Random();
                  int empCheck = random.Next(0,3);
                  switch(empCheck)
                  {
                    case partTimeHrs :
                    empHrs=4;
                    // EmpWagePerDay= partTimeHrs*wagePerHour;
                    // EmpWagePerMonth=EmpWagePerDay*workingDayPerMonth;
                    // Console.WriteLine("Part time employee wage is:" +EmpWagePerDay);
                    // Console.WriteLine("Part time employee wage per month is:" +EmpWagePerMonth);
                    break;

                    case FullTimeHrs :
                    empHrs=8;
                    // EmpWagePerDay= FullTimeHrs*wagePerHour;
                    // EmpWagePerMonth=EmpWagePerDay*workingDayPerMonth;
                    // Console.WriteLine("Full time employee wage is:" +EmpWagePerDay);
                    // Console.WriteLine("Full time employee wage per month is:" +EmpWagePerMonth);
                    break;

                    default :
                    empHrs=0;
                    break;
                  }
                  totalEmpHrs += empHrs;
                  Console.WriteLine("Days : " +totalWorkingDays + "Emp hrs : " +empHrs);
            }      
                  int totalEmpWage = totalEmpHrs * wagePerHour;
                  Console.WriteLine("Total Employee wage : " +totalEmpWage);
                  return totalEmpWage;
		}
   	}
}