using System;

namespace Method2
{
    class Program
    {

        int n1;
        int n2;
       
        static void PrintMessage(int typeToPrint)
        {

            int n1;
            int n2;
            int resultplus;
            string resultplus1;
           
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


            if (typeToPrint == 1)
            {
                resultplus = n1 + n2;
                resultplus1 = resultplus.ToString();

                Console.WriteLine("The sum of " + n1 + " and " + n2 + " is: " + resultplus1);
            }

            else if(typeToPrint == 2)
            {
                resultplus = n1 - n2;
                resultplus1 = resultplus.ToString();

                Console.WriteLine("The subtraction of " + n1 + " and " + n2 + " is: " + resultplus1);
            }








        }


        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ayush Chauhan");


            

            PrintMessage(1);
            PrintMessage(2);




        }

    }
}
