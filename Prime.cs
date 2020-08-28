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
        //Program to counts and display total prime number
        static void Main(string[] args)
        {
            int i, j, cnt = 0;
            bool prime;
            for ( i = 0; i < 20; i++)
            {
                prime = true;
                for ( j = 2; j < i  ; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime == true)
                {
                    Console.WriteLine(i+"\t");
                    cnt++;
                }

            }
            Console.WriteLine("Total prime no : "+cnt);

            Console.ReadLine();
        }
    }
}
