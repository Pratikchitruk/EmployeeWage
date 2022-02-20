using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeCheck
    {

        public static void EmployeePresentOrNot()
        { 
        Random random = new Random();
            int number = random .Next(2);

            if (number == 1)
            {
                Console.WriteLine("empoyee present");
            }
            else
            {
                Console.WriteLine("Empoyee Absent");
            }
        }

    }
}
