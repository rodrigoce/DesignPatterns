using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o Design Pattern");
            Console.WriteLine("");
            Console.WriteLine("S - Single Responsibility Principle");
            Console.WriteLine("O - Open-Closed Principle");
            Console.WriteLine("L - Liskov Substituition Principle");
            Console.WriteLine("I - Interface Segregation Principle");
            Console.WriteLine("D - Dependency Inversion Principle");

            Console.WriteLine("a - Builder and Fluent Builder");
            Console.WriteLine("b - Fluent Builder Inheritance With Recursive Generics");
            Console.WriteLine("c - Functional Builder");
            Console.WriteLine("d - Faceted Builder");
            var c = Console.ReadKey();
            Console.Clear();

            switch (c.KeyChar)
            {

                case 'S':
                    SOLID.SRP.Demo.Main2();
                    break;
                case 'O':
                    SOLID.OCP.Demo.Main2();
                    break;
                case 'L':
                    SOLID.LSP.Demo.Main2();
                    break;
                case 'I':
                    Console.WriteLine("This exemple do not run code.");
                    break;
                case 'D':
                    SOLID.DIP.Research.Main2();
                    break;
                case 'a':
                    Builder.Demo.Main2();
                    break;
                case 'b':
                    Builder.FluentBuilderInherit.Program2.Main2();
                    break;
                case 'c':
                    Builder.FunctionalBuilder.Program.Main2();
                    break;
                case 'd':
                    Builder.FacetedBuilder.Demo.Main2();
                    break; 
                default:
                    break;
            }
        }
    }    
}
