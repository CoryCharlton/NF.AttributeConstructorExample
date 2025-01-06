using System;
using System.Threading;
using AttributeConstructorExample.Attributes;

namespace AttributeConstructorExample
{
    public class Program
    {
        public static void Main()
        {
            var attributes = (typeof(TestClass)).GetCustomAttributes(true);

            foreach (var attribute in attributes)
            {
                if (attribute is not IValueAttribute valueAttribute)
                {
                    continue;
                }

                Console.WriteLine($"-- {valueAttribute.GetType()} -- CtorValue: {valueAttribute.CtorValue} -- PropValue: {valueAttribute.PropValue}");
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
