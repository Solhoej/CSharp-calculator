using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Calculator menu, choose from following options: " +
                    "\n 1: Simple operations " +
                    "\n 2: Quadratic functions " +
                    "\n 3: Vectors" );
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                    float simpleResult;
                    Console.WriteLine("Enter first number");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operator: (+, -, *, /, ^)");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            simpleResult = num1 + num2;
                            Console.WriteLine("Addition: " + simpleResult);
                            break;
                        case "-":
                            simpleResult = num1 - num2;
                            Console.WriteLine("Subtraction: " + simpleResult);
                            break;
                        case "*":
                            simpleResult = num1 * num2;
                            Console.WriteLine("Multiplication: " + simpleResult);
                            break;
                        case "/":
                            simpleResult = num1 / num2;
                            Console.WriteLine("Divition: " + simpleResult);
                            break;
                        case "^":
                            simpleResult = (float)Math.Pow(num1, num2);
                            Console.WriteLine("Exponent: " + simpleResult);
                            break;
                        default:
                            Console.WriteLine("Enter valid number");
                            break;
                    }
                        break;
                    case 2:
                        float quadraticResult;
                        float discriminant;
                        Console.WriteLine("Enter a value");
                        float numA = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter b value");
                        float numB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter c value");
                        float numC = float.Parse(Console.ReadLine());

                        discriminant = (float)(Math.Pow(numB, 2)) - 4 * numA * numC;
                        if (discriminant <= 0)
                            Console.WriteLine("The discriminent is negative, there is no solution");
                        else
                        {
                            float sqrtDiscriminant = (float)Math.Sqrt(discriminant);
                            float denominator = 2 * numA;

                            float root1 = (-numB + sqrtDiscriminant) / denominator;
                            float root2 = (-numA - sqrtDiscriminant) / denominator;

                            Console.WriteLine("Root 1 is: " + root1);
                            Console.WriteLine("Root 2 is: " + root2);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Are you calculating vectors in 2d or 3d?");
                        string dimension = Console.ReadLine();
                        if (dimension == "2d")
                        {
                            Console.WriteLine("What do you want to calculate " +
                                "\n Length of the vector " +
                                "\n")
                        }  
                        else
                        {

                        }
                        break;
                }
                Console.WriteLine("Do you want to continue (y/n)");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y");
        }
    }
}