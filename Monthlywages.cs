using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Monthlywages

    {


        public static void MonthlyWages()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int IS_MONTHLY = 3;
            int EMP_RATE_PER_HOUR = 20;
            int EMP_RATE_PER_DAY = 1000;

            int empHrs = 0;
            int empwage = 0;
            int empDays = 0;

            Random random = new Random();
            int empCheck = random.Next(4);

            if (empCheck == IS_PART_TIME)
            {
                empCheck = 4;
            }
            else if (empCheck = IS_FULL_TIME)
            {
                empCheck = 8;

            }
            else if (empCheck == IS_MONTHLY)
            {
                empCheck = 20;
            }
            empwage = empHrs * EMP_RATE_PER_HOUR;
            empDays = empHrs * EMP_RATE_PER_DAY;
            Console.WriteLine("emp wage :" + empwage +"emp days :" + empDays);
        }

    }

}



