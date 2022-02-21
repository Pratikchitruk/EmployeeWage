using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CalculateDailyWage
    {
        public static void CalculateWage() 
        {
            int WagePerHour = 20;
            int FullWorkingDay = 8;
            int calculateWage = 0;

            Random random = new Random();
            int number = random.Next(2);

            if (number == 1)
            {
                calculateWage  = WagePerHour * FullWorkingDay;
                
                Console.WriteLine("calculate Wage = " + calculateWage);
            }
            else
            {
                calculateWage = 0;
                Console.WriteLine("calculate Wage = " + calculateWage);
            }
        }
    }
}
