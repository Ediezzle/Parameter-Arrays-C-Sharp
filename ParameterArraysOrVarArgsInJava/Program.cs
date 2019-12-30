using System;

namespace ParameterArraysOrVarArgsInJava
{
    class Program
    {
        static void Foo(int x, params string[] values)
        {
            Console.Write(x);
            for (int i = 0; i < values.Length - 1; i++)
            {
                Console.Write(", " + values[i]);  
            }
            
        }
        static void Main(string[] args)
        {
            Foo(5, "Hazy", "Dee");

            Console.WriteLine();

            Foo(12, "Eddaz", "Irv", "Laatie");
            string[] array = { "Ellaz", "Henso", "OurOwnDavido", "Rue"};

            Console.WriteLine();

            Foo(8, array);
        }
    }
}
