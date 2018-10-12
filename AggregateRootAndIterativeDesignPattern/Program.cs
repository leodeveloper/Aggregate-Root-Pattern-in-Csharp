using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateRootAndIterativeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAddress employeeAddress = new EmployeeAddress();
            employeeAddress.Add("123 Road");
            employeeAddress.Add("1234 Road");
            employeeAddress.Add("1235 Road");
            employeeAddress.Add("1236 Road");

            foreach (var address in employeeAddress.Addresses)
            {
                Console.WriteLine(address);
            }

            Console.ReadLine();
        }
    }
}
