/* 10x10 rows and cols
 * Random numbers  0 to 1000
 * prime numbers
 * Index
*/

using System;

public class Program
{

    public static bool isPrime(int n) // find prime numbers
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= boundary; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }

    public static void Main() //start of main
    {
        int[,] twoD = new int[10, 10];
        Random values = new Random();

        Console.WriteLine("\n Table of Random Numbers:\n");

        for (int a = 0; a < 10; a++) //Fills twoD with random numbers
        {
            for (int b = 0; b < 10; b++)
            {
                twoD[a, b] = values.Next(0, 1000);
                Console.Write(twoD[a, b] + "\t"); //Prints twoD
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n Table of Primes in that list:\n");

        for (int a = 0; a < 10; a++) // prints primes
        {
            for (int b = 0; b < 10; b++)
            {
                if (isPrime(twoD[a, b]))
                    Console.Write(twoD[a, b] + "\t");
                else
                    Console.Write("____\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n Table of The Index of each Prime:\n");
        for (int a = 0; a < 10; a++) // prints index
        {
            for (int b = 0; b < 10; b++)
            {
                if (isPrime(twoD[a, b]))
                    Console.Write("(" + a + "," + b + ")\t");
                else
                    Console.Write("____\t");
            }
            Console.WriteLine();
        }
    } 
}
