﻿using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyString();
        }

        static void MyString()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first String";
            string theTruth = "The last thing a ninja would do is admit being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine( "This is my String. " +myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
        }
    }
}
