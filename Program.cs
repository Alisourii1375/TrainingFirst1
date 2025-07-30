// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
class Program
{
    static void Main(string[] agres)
    {


        Console.WriteLine("Please Enter A Number");
        string Input = Console.ReadLine();
        int Number = int.Parse(Input);
        if (Number > 0 && Number < 10)
        {
            if ((Number / 2) == 0)
            {
                Number = Number - 5;
                Console.WriteLine("Entered Number" + Number);
            }
            else
            {
                Number = Number + 5;
                Console.WriteLine("Entered Number" + Number);
            }
        }
        else
        {
            Console.WriteLine("Number not valid");
        }
        


    }
}