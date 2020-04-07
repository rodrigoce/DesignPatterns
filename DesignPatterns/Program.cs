using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o Design Pattern");
            Console.WriteLine("");
            Console.WriteLine("a - Fluent Builder Inheritance With Recursive Generics");
            var c = Console.ReadKey();

            switch (c.KeyChar)
            {
                case 'a':
                    FluentBuilderInheritanceWithRecursiveGenerics.Program2.Main2();
                    break; 
                default:
                    break;
            }
        }
    }    
}
