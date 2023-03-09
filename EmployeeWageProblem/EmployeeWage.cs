using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1, TOTAL_WORKING_DAYS = 20, TOTAT_WORKING_HRS = 100;

        //UC1-Attendence
        public void Attendence()
        {
            Random random = new Random(); //inbuilt classe using which we can choose random r
            int check = random.Next(0, 2);//0, 1
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        //Commit the code to uc1 branch and merge with main
        //UC2-DailyEmpWage
        public void DailyEmpWage()
        {
            int empHrs = 0;
            Random random = new Random();
            for (int i = 0; i < TOTAL_WORKING_DAYS && empHrs < TOTAT_WORKING_HRS; i++)
            {

                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        empHrs = FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs = PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                int wage = WAGE_PER_HR * empHrs;
                Console.WriteLine(wage);


            }


        }
    }
}
