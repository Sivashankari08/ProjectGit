using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter Age :");
        age = Convert.ToInt32(Console.ReadLine());
        if(age >=18){
            Console.WriteLine("Eligible to vote");
        }
        else{
            Console.WriteLine("Not eligible to vote");
        }
        
        Console.ReadLine();
        
    }
}


