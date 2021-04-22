using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        switch(Choice)
        {
            case 1:
                Console.WriteLine("Add");
                break;
            case 2:
                Console.WriteLine("SUB");
                break;
            default:
                Console.WriteLine("nthg");
                break;
        }
        Console.ReadLine();
    }
}