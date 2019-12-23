using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// шагов александр. Задача 1: С помощью рефлексии выведите все свойства структуры DateTime
 

namespace Task_1_StructDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var pr in typeof(DateTime).GetProperties())
            {
                Console.WriteLine(pr.Name);
            }
           
            Console.ReadKey();
        }
    }
}
