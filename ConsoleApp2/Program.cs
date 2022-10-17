using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("год:" + "2019, 2020, 2021, 2022 ");
            char n = char.Parse(Console.ReadLine());
            switch (n)
            {
                case (char)2019 :
                    Console.WriteLine("Год какого животного: ");
                    Console.Write("Животное= ");
                    double a = double.Parse(Console.ReadLine());
                    {
                        Console.WriteLine("p={Желтая свинья}");
                    }
                    break;
                case (char)2020:
                    Console.WriteLine("Год какого животного");
                    Console.Write("Животное= ");
                    double b = double.Parse(Console.ReadLine());
                    {
                        Console.WriteLine("p={Белая крыса}");
                        break;
                    }
            }
        }
    }
}
