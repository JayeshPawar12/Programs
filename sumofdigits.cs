using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
    class Program 
    {
        //Program for sum the digits of a given number 456=15
        static void Main(string[] args)
        {
            int n, sum = 0, k;
            Console.Write("Enter digits  : ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                k = n % 10; 
                n = n / 10; 
                sum = sum + k;
            }
            Console.WriteLine("Sum of digits are  : "+sum);

            Console.ReadLine();
        }
    }
}
