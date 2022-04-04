using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage

    {  
        

        public static void calEmpWage()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            
            int empHrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_PART_TIME)
            {
                empCheck = 4;
            }
            else if (empCheck = IS_FULL_TIME )
                {
                empCheck = 8;

            }
            else
            
           { 
           empHrs = 0;
            }
            empwage = empHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage :" + empwage);
        }
        
    }

}

    
    
