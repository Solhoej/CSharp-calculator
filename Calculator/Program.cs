namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string value;
            do
            {
                float result;
                Console.WriteLine("Enter first number");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator: (+, -, *, /)");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraction: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Divition: " + result);
                        break;
                    default:
                        Console.WriteLine("Enter valid number");
                        break;
                }
                Console.WriteLine("Do you want to continue (y/n)");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y");
        }
    }
}