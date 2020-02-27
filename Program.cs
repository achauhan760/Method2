using System;

namespace Method2 {
    class Program {
       
        static void PrintMessage(int n1, int n2, string function){

            bool divByZero = false;

            if(n2 == 0){
                divByZero = true;
            }

            switch (function.ToLower()){
                case "addition":
                    Console.WriteLine("The sum of " + n1 + " and " + n2 + " is " + (n1 + n2));
                    break;
                case "subtraction":
                    Console.WriteLine("The difference between " + n1 + " and " + n2 + " is " + (n1 - n2));
                    break;
                case "multiplication":
                    Console.WriteLine("The profuct of " + n1 + " and " + n2 + " is " + (n1 * n2));
                    break;
                case "division":
                    if(divByZero){
                        Console.WriteLine("Error: Division by zero.");
                    } else {
                        Console.WriteLine("The quotient " + n1 + " and " + n2 + " is " + (n1 / n2));
                    }
                    break;
                default:
                    Console.WriteLine("Unknown arithmetic function.");
                    break;

            }
        }

        static void Main(string[] args){
            Console.WriteLine("Ayush Chauhan");

            int n1;
            int n2;
            string func;
           
            Console.WriteLine("Please Enter Your First Integer: ");

            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.Clear();
                Console.Write("Enter only a number please! 1,2,3, etc. ");

            }
            Console.WriteLine("Your First Integer: " + n1);

            Console.WriteLine("Please Enter Your Second Integer: ");

            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.Clear();
                Console.Write("Enter only a number please! 1,2,3, etc. ");

            }
            Console.WriteLine("Your Second Integer: " + n2);
            
            Console.WriteLine("\nPlease Enter Your Arithmetic Operation(\"Addition\", \"Subtraction\", \"Multiplication\", \"Division\"): ");
            func = Console.ReadLine();

            PrintMessage(n1, n2, func);
        }
    }
}
