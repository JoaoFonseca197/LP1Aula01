﻿using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num1 ,num2;
            num1 = 3;
            num2 = 4;
            char Iene ='\u00A5';
            char Circle  = '\u058D';
            float numfloat1 = 3.666f;
            float numfloat2= 3.555f;
            bool Correct = true;
            bool Incorrect = false ;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(Iene);
            Console.WriteLine(Circle);
            Console.WriteLine(numfloat1);
            Console.WriteLine(numfloat2);
            Console.WriteLine(Correct);
            Console.WriteLine(Incorrect);
        }
    }
}
