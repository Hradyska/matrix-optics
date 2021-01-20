using System;
using static System.Console;
using static matrix_optics_2.parseBD;

namespace matrix_optics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte [] binary = new byte[128];
            (new Random()).NextBytes(binary);
            WriteLine("Binary object as bities:");
            for(int i=0;i<binary.Length; i++)
            {
                Write($"{binary[i]:X}");
            }
            string encoded=Convert.ToBase64String(binary);
            WriteLine("Binary object as Base64:");
            WriteLine(encoded);
            byte []fromBase64tobinary=Convert.FromBase64String(encoded);
            WriteLine("Binary object as bities:");
            for(int i=0;i<binary.Length; i++)
            {
                Write($"{binary[i]:X}");
            }
            WriteLine("enter your BirthDay:");
            string bDay=ReadLine();
            DateTime  birthDay=BD(bDay);
            int age =myAge(bDay);
            WriteLine($"my BD is {birthDay:D}, my age is {age}");
            WriteLine("enter some number");
            int count;
            string input=Console.ReadLine();
            if(int.TryParse(input,out count))
            {
                WriteLine($"{count}");
            }
            else
            {
                WriteLine("this line cannot to be parse");
            }
            


        }
    }
}
