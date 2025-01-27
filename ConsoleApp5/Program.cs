using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 0;
        while (b < 34)
        {
            Console.WriteLine(b);
            b = b + a;
            Console.WriteLine(a);
            a = a + b;
        }
    }
}