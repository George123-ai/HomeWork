using System.Net.Http.Headers;
using System.Xml.XPath;

namespace Calculator
{
    internal class Program
    {
        static void Sum(ref float num1, ref float num2, ref float result)
        {
            result = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} = {result}");
        }

        static void Subtraction(ref float num1, ref float num2, ref float result)
        {
            result = num1 - num2;
            Console.WriteLine($"Subtraction of {num1} and {num2} = {result}");
        }

        static void Addition(ref float num1, ref float num2, ref float result)
        {
            result = num1 * num2;
            Console.WriteLine($"Addition of {num1} and {num2} = {result}");
        }

        static void Division(ref float num1, ref float num2, ref float result)
        {
            result = num1 / num2;
            Console.WriteLine($"Division of {num1} and {num2} = {result}");
        }

        static void Main(string[] args)
        {
            float num1, num2, result;
            char operation;
            bool again = false;
            string answer;

            do
            {
                Console.Clear();

                while (true)
                {
                    Console.Write("Input first number: ");
                    bool num = float.TryParse(Console.ReadLine(), out num1);
                    if (num)
                    {
                        break;
                    }
                }
                //num1 = float.Parse(Console.ReadLine());
                while (true)
                {
                    Console.Write("Input second number: ");
                    bool num = float.TryParse(Console.ReadLine(), out num2);
                    if (num)
                    {
                        break;
                    }
                }
                //Console.Write("Input second number: ");
                //num2 = float.Parse(Console.ReadLine());
                while (true)
                {
                    Console.Write("Input operation: (+, -, *, /): ");
                    //operation = Char.Parse(Console.ReadLine());
                    bool op = char.TryParse(Console.ReadLine(), out operation);
                    if (op && operation=='+' || op && operation == '-' || op && operation == '*'|| op && operation == '/')
                    {
                        break;
                    }
                }
                //Console.Write("Input operation: (+, -, *, /): ");
                //operation = Char.Parse(Console.ReadLine());

                result = 0;

                switch (operation)
                {
                    case '+':
                        Sum(ref num1, ref num2, ref result);
                        break;
                    case '-':
                        Subtraction(ref num1, ref num2, ref result);
                        break;
                    case '*':
                        Addition(ref num1, ref num2, ref result);
                        break;
                    case '/':
                        Division(ref num1, ref num2, ref result);
                        break;
                    default:
                        {
                            Console.WriteLine("You entred wrong operation! Try again.");
                            break;
                        }
                }

                do
                {
                    Console.WriteLine("Exit ? (Yes/No)");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "yes" || answer == "y")
                    {
                        again = false;
                        break;
                    } 
                    else if (answer == "no" || answer == "n")
                    {
                        again = true;
                        break;
                    }
                        
                }while(answer != "yes" || answer != "y" || answer != "no" || answer != "n");

            } while(again);
        }
    }
}