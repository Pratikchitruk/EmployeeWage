using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employeewage

    {
     

        public static void calEmpWage()
        {
            int iS_PART_TIME = 1;
            int iS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch(empCheck)
            {
                case iS_PART_TIME:
                    empHrs = 4;
                    break;

                    case iS_FULL_TIME:
                    empHrs = 8;
                    break;

                    default:
                    empHrs = 0;
                    break;
            }
            empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage :" + empwage);
        }

    }

}