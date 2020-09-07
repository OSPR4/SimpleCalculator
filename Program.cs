using System;
/*
Class:       ISTA 220 Programming Fundamentals in C#
Student:     Osee Pierre
Instructor:  Christine Lee
Date:        08/01/20
Description: Simple math calculator with Addition, Subtraction, Multiplication, and Division capabilities
Revised:     
Revised by: 
Revision:   
*/

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    char selection;
                    double num1;
                    double num2;

                    Console.WriteLine("1: For Addition Enter +  \n2: For Subtraction Enter - \n3: For Multiplication Enter * \n" +
                    "4: For Division Enter /\n5: Enter X to Exit\n");
                    Console.Write("Enter selection: ");

                    //exit option
                    selection = char.Parse(Console.ReadLine());
                    if (selection == 'E' || selection == 'e')
                    {
                        Console.WriteLine("Thank you");
                        break;
                    }

                    //check selected mathematical operator 
                    if (selection != '+' && selection != '-' && selection != '*' && selection != '/')
                    {
                        Console.WriteLine("Thanks for stopping by!");
                        break;
                    }



                    Console.WriteLine();

                    Console.Write("Enter 1st digit: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd digit: ");
                    num2 = double.Parse(Console.ReadLine());

                    switch (selection)
                    {
                        case '+':
                            Add(num1, num2);
                            break;
                        case '-':
                            Subtract(num1, num2);
                            break;
                        case '*':
                            Multiple(num1, num2);
                            break;
                        case '/':
                            while (num2 == 0)
                            {
                                Console.Write("Division by zero is not a valid choice\n Enter 2nd digit: ");
                                num2 = double.Parse(Console.ReadLine());
                            }
                            Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Thanks for stopping by!");
                            break;
                    }
                    Console.WriteLine();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }


        static void Add(double num1, double num2)
        {
            try
            {            
              double result = num1 + num2;
              Console.WriteLine($"{num1} + {num2} = {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        static void Subtract(double num1, double num2)
        {
            try
            {
                double result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        static void Multiple(double num1, double num2)
        {
            try
            {
                double result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        static void Divide(double num1, double num2)
        {
            try
            {
                double result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
