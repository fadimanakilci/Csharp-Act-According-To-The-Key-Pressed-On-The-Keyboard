 
// Run the "dotnet run" command from the terminal.


using System;
using System.Collections.Generic;
using System.Linq;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            Console.WriteLine("A Press: Print all numbers from 1 to 100 to the console, in ascending order.");
            Console.WriteLine("S Press: Print all numbers from 1 to 100 to the console in descending order.");
            Console.WriteLine("D Press: Calculate the sum of numbers from 1 to n");
            Console.WriteLine("Esc Press: Quit");

            do{
                keyInfo = Console.ReadKey(true);
                Console.Clear();
                // 1 to 100
                if(keyInfo.Key == ConsoleKey.A){
                    for(int i=1; i<=100; i++)
                        Console.Write(i.ToString() + "\t");
                }
                // 100 to 1
                else if(keyInfo.Key == ConsoleKey.S){
                    for(int j=100; j>=1; j--)
                        Console.Write(j.ToString() + "\t");
                }
                // sum(1 to n)
                else if(keyInfo.Key == ConsoleKey.D){
                    Console.WriteLine("Calculate the sum of numbers from 1 to n");
                    Console.WriteLine("Z Press: Implementation using a for-loop.");
                    Console.WriteLine("X Press: Implementation using a while-loop.");
                    Console.WriteLine("C Press: Implementation using LINQ.");
                    Console.WriteLine("Esc Press: Quit");
                    do{
                        keyInfo = Console.ReadKey(true);
                        Console.Clear();
                        // Implementation using a for-loop.
                        if(keyInfo.Key == ConsoleKey.Z){
                            Console.Write("Please Enter A Number: ");
                            String n = Console.ReadLine();
                            int num = Convert.ToInt32(n);
                            int result = Sum(num);
                            Console.WriteLine("Result = " + result);
                        // Implementation using a while-loop.
                        }else if(keyInfo.Key == ConsoleKey.X){
                            Console.Write("Please Enter A Number: ");
                            String n_A = Console.ReadLine();
                            int num_A = Convert.ToInt32(n_A);
                            int result_A = Sum_A(num_A);
                            Console.WriteLine("Result = " + result_A);
                        // Implementation using LINQ.
                        }else if(keyInfo.Key == ConsoleKey.C){
                            Console.Write("Please Enter A Number: ");
                            String n_B = Console.ReadLine();
                            int num_B = Convert.ToInt32(n_B);
                            int result_linq = Sum_B(num_B);
                            Console.WriteLine("Result = " + result_linq);
                            
                        }else{
                            Console.WriteLine("Please enter the characters 'Z', 'X', 'C' or Esc on the keyboard.");
                        }
                    }while (keyInfo.Key != ConsoleKey.Escape);
                    
                }else{
                    Console.WriteLine("Please enter the characters 'A', 'S', 'D' or Esc on the keyboard.");
                }
            }while (keyInfo.Key != ConsoleKey.Escape);
            
        }
        // Sum method => Implementation using a for-loop.
        public static int Sum(int n){
            int sum = 0;
            for(int i=0; i<=n; i++)
                sum += i;
            return sum;
        }
        // Sum_A method => Implementation using a while-loop.
        public static int Sum_A(int n){
            int a = 1, sum_A = 0;
            while(a != (n+1)){
                sum_A += a;
                a++;
            }
            return sum_A;
        }
        // Sum_B method => Implementation using LINQ.
        public static int Sum_B(int n){
            int sum_B = Enumerable.Range(1, n).Sum();
            return sum_B;
        }
    }
}
