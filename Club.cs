using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Susan";
            int age = 0;
            Console.Write("Hello " + name + " how old are you: ");
            age = int.Parse(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("Welcome to Halimat's club, what would you like to drink");
            }
            else if (age <=11)
            {
                Console.WriteLine("Are you lost,Do you know your guidian's phone number");
            }
            else
            {
                Console.WriteLine("You are to young to be here, Please leave");
            }
            string Myname = "Christina";
            int Myage = 0;
            Console.Write("Hello " + Myname + " how old are you: ");
            Myage = int.Parse(Console.ReadLine());
            if(Myage >= 18)
            {
                Console.WriteLine("Welcome to Halimat's club, what would you like to drink");
            }
            else if(age <=11)
            {
                Console.WriteLine("Are you lost,Do you know your guidian's phone number");
            }
            else
            {
                Console.WriteLine("You are to young to be here, Please leave");
            }
            string Hisname = "Jael";
            int Hisage = 0;
            Console.Write("Hello " + Hisname + " how old are you: ");
            Hisage = int.Parse(Console.ReadLine());
            if(Hisage >= 18)
            {
                Console.WriteLine("Welcome to Halimat's club, what would you like to drink");
            }
            else if (age <=11)
            {
                Console.WriteLine("Are you lost,Do you know your guidian's phone number");
            }
            else
            {
                Console.WriteLine("You are to young to be here, Please leave");
            }
        }
    }
}
