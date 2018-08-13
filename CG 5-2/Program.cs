using System;

namespace CG_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter 2 numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Please choose +, -, * or /");
            string op = Console.ReadLine();
            if (op == "+")
            
            {
                Console.WriteLine(x + y);
            }
            else if (op == "-")
            {
                Console.WriteLine(x - y);
            }
            else if (op == "x")
            {
                Console.WriteLine(x * y);
            }
            else if (op == "/") 
            {
                Console.WriteLine(x / y);
            }
            else { Console.WriteLine("you did not follow directions"); }
            
            Console.ReadLine();

            */
            int firstnumber;
            int secondnumber;
            int answer;
            string operation;

            Console.WriteLine("Welcome to a simple calculator. Please enter the first number:");

            firstnumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            secondnumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the operator by typing +, -, *, or /");

            operation = Console.ReadLine();
                       
            switch (operation)
            {
                case "+":
                    answer = Addition(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + "+" + secondnumber + "=" + answer); break;

                case "-":
                    answer = Subtraction(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + "-" + secondnumber + "=" + answer); break;

                case "*":
                    answer = Multiply(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + "*" + secondnumber + "=" + answer); break;

                case "/":
                    answer = Division(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + "/" + secondnumber + "=" + answer); break;

                default:

                    Console.WriteLine("Invalid operator"); break;
                                                  
            }
            Console.ReadLine();
                
        }
        /// <summary>
        /// adds 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>2 numbers added</returns>
        private static int Addition(int num1, int num2)
        {
            return (num1 + num2);
        }
        /// <summary>
        /// subtracting num2 from num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num2 is subtracted from num1</returns>
        private static int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }
        /// <summary>
        /// multiply 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is multiplied by num2</returns>
        private static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }/// <summary>
        /// 2 numbers divided
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 divided by num2</returns>
        private static int Division(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}

