using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_TASK_EVEN__AND_ODD_NUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even number from 1 to 35");
            for (int i = 1; i <= 35; i++)
            {
                if (i % 2 == 0)

                {
                    Console.WriteLine(i);
                }

            }
            
            Console.WriteLine("odd number from 1 to 35");
            for (int i = 1; i <= 35; i++)
            {
                if (i % 2 != 0)

                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadKey();

        }
    }
}
