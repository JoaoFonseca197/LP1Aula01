using System;

namespace VariusStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 420;
            int y = 69;
            string comida = ("Pão com queijo");
            string acucar = (@""" acucar""");
            string smoke = ("smoke " + "weed " + "at" + x);
            string best_numbers = ($"best numbers are {x} and {y}");
            string Dead = ($@"""Omewa Mo {x}ero""");
            double xx = 0.12345;
            int ii = 18;
            Console.WriteLine(comida);
            Console.WriteLine(acucar);
            Console.WriteLine(smoke);
            Console.WriteLine(best_numbers);
            Console.WriteLine(Dead);
            Console.WriteLine($"x={xx:f2}");
            Console.WriteLine($"x={xx:p1}");
            Console.WriteLine($"x={ii:x}");
            Console.WriteLine($"x={ii:c}");


        }
    }
}
