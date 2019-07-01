using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(2);
            array[0] = 6;
            array[1] = 10;
           

            for (int i = 0; i < array.Size; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}