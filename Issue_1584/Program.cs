using System;
using System.Threading;

namespace Issue_1584
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("[1] Program starting");

            var attributes = typeof(ExampleClass).GetCustomAttributes(true);

            Console.WriteLine($"[3] {attributes.Length} attribute retrieved.");
            Console.WriteLine($"[4] Attribute is of type {attributes[0].GetType().Name}");

            Thread.Sleep(Timeout.Infinite);
        }
    }

    public class ExampleAttribute : Attribute
    {
        public ExampleAttribute()
        {
            Console.WriteLine($"[2] {nameof(ExampleAttribute)}.ctor() is never called");
        }
    }

    [Example]
    public class ExampleClass
    {

    }
}
