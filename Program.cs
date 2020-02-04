using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Work branch being used.");
        }
    }

    // Builder interface used to define all the steps to create a product
    interface Builder {

    }
    // Implements the Builder interface to create a complex product
    class ConcreteBuilder : Builder
    {
        
    }
}