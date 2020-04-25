using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.FunctionalBuilder
{
    public class Person
    {
        public string Name, Position;

        public override string ToString()
        {
            return $"{Name}, {Position}";
        }
    }

    public abstract class FunctionalBuiler<TSubject, TSelf>
       where TSelf : FunctionalBuiler<TSubject, TSelf>
       where TSubject : new()
    {   
        private readonly List<Func<TSubject, TSubject>> actions
            = new List<Func<TSubject, TSubject>>();

        public TSelf Do(Action<TSubject> action) => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            actions.Add(p => { action(p); return p; });
            return (TSelf) this;
        }

        public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));
    }

    public sealed class PersonBuilder : FunctionalBuiler<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(p => p.Name = name);
    }

    //public sealed class PersonBuilder
    //{
    //    private readonly List<Func<Person, Person>> actions
    //        = new List<Func<Person, Person>>();

    //    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    //    public PersonBuilder Position(string position) => Do(p => p.Position = position);
    //    public PersonBuilder Do(Action<Person> action) => AddAction(action);

    //    private PersonBuilder AddAction(Action<Person> action)
    //    {
    //        actions.Add(p => { action(p); return p; });
    //        return this;
    //    }

    //    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
    //}

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs
            (this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }

    static class Program
    {
        public static void Main2()
        {
            var person = new PersonBuilder().Called("Rodrigo")
                .WorksAs("principal").Build();

            Console.WriteLine(person.ToString());

            var l = new List<int>() { 1, 2, 3 };
            
            Console.WriteLine( l.Aggregate((total, cara) => total += cara) );
        }
    }
}
