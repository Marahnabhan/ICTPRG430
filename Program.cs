using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            /*SayHello();

            Welcome("John");

            AddTwoNums(15,16);

            NumOfSpaces();

            SumOfArray();

            SwapNumbers();

            NumberToPower();

            Fibonacci();

            CheckPrime();

            SumIndividualNums();

            Factorial();*/

            FibonnaciTerm();
        }

        /*static void SayHello()
        {
            Console.WriteLine("Welcome Friends!\nHave a nice day!");
        }

        static void Welcome(string pName)
        {
            Console.WriteLine("Welcome friend " + pName + "!\nHave a nice day!");
        }

        static void AddTwoNums(int n1, int n2)
        {
            int sum = n1 + n2;
            Console.WriteLine("The sum of the two numbers is: " + sum);
        }

        static void NumOfSpaces()
        {
            Console.WriteLine("Please input a string: ");
            string str = Console.ReadLine();
            int spcctr=0;
		    string str1;
		    for (int i = 0;i < str.Length;i++)
			{
			  str1 = str.Substring(i,1);
			  if (str1 == " ")
					spcctr++;
			}
            Console.WriteLine("String contains " + spcctr + " spaces");
        }

        static void SumOfArray()
        {
            int[] numbers = new int[5];
            int i, sum = 0;
            Console.WriteLine("Input 5 elements in the array: ");
            for(i = 0; i < 5; i++)
            {
                Console.Write("element " + i + " : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine("The sum of the elements of the array is: " + sum);
        }

        static void SwapNumbers()
        {
            int x1, x2, x3;
            Console.Write("Enter a number: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            x3 = x1;
            x1 = x2;
            x2 = x3;
            Console.WriteLine("Nor the 1st number is: " + x1 + ", and the 2nd number is: " + x2);
        }

        static void NumberToPower()
        {
            int b, e, r = 1;
            Console.Write("Input Base number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Exponent: ");
            e = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < e; i++)
                r *= b;
            Console.WriteLine("So, the number " + b + "^" + e + " = " + r);
        }

          static void Fibonacci()
        {
            int n, i;
            Console.Write("Input number of Fibonnaci Series: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for(i = 2; i < n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            Console.WriteLine("The Fibonnaci series of " + n + " numbers is: ");
            for(i = 0; i < n; i++)
                Console.Write(fib[i] + " ");
        }

        static void CheckPrime()
        {
            int n, c = 1;
            Console.Write("Input a positive number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n > 4)
                for(int i = 2; i < n; i++)
                    if(n%i == 0)
                    {
                        c = 0;
                        Console.WriteLine(n + " is not a prime number");
                        break;
                    }
            if(c == 1) 
                Console.WriteLine(n + " is a prime number");
        }

        static void SumIndividualNums()
        {
            int x, sum = 0;
            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            int num = x
            while(x > 0)
            {
                sum += x % 10;
                x /= 10;
            }

            Console.WriteLine("The sum of the digits of the number " + num + " is: " + sum);
        }

        static void Factorial()
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for(int i = x; i > 1; i--)
                f *= i;
            Console.WriteLine("the factorial of " + x + "! is " + f);
        }*/

        static int Fibonacci1(int n)
        {
            int i;
            
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;
            for(i = 2; i < n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            return fib[n-1];
        }

        static void FibonnaciTerm()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int t;
            t = Fibonacci1(n);
            Console.WriteLine("The Fibonnaci of the " + n + "th term is " + t);
        }
    }   
}
