using System;

namespace Building_a_better_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");

            var input = Console.ReadLine();
            input = input.Replace('.', ',');

            double num1 = Convert.ToDouble(input);
       
            Console.Write("Enter Operator: ");
            var op = Console.ReadLine();

            Console.Write("Enter a number: ");

            input = Console.ReadLine();
            input = input.Replace('.', ',');
            double num2 = Convert.ToDouble(input);

            if (op == "+") 
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
              else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
              else
            {
                Console.WriteLine("Invalid Operator");
            }


        }
    }
}
//hvis du bare skal bytte ut en karakter kan du bruke ' ', mens skal du bytte ut flere karakterer (string) så bruker du " "
//string.replace bytter ut en karakter eller en del av en string til noe annet 