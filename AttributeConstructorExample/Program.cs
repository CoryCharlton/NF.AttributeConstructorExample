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

            Console.WriteLine($"Attribute count: {attributes.Length}");

            for (var i = 0; i < attributes.Length; i++)
            {
                var attribute = attributes[i];

                if (attribute is null)
                {
                    Console.WriteLine($"!! [{i}] Attribute is null. No object creation attempted??");
                    continue;
                }

                Console.WriteLine($"-- [{i}] {attribute.GetType().Name}");

                switch (attribute)
                {
                    case FieldParameterAttribute fieldParameterAttribute:
                    {
                        Console.WriteLine($"---- FieldValue: {fieldParameterAttribute.FieldValue}");
                        break;
                    }
                    case NoParameterAttribute noParameterAttribute:
                    {
                        Console.WriteLine($"---- CtorValue: {noParameterAttribute.CtorValue} -- PropValue: {noParameterAttribute.PropValue}");
                        break;
                    }
                    case OptionalParameterAttribute optionalParameterAttribute:
                    {
                        Console.WriteLine($"---- CtorValue: {optionalParameterAttribute.CtorValue} -- PropValue: {optionalParameterAttribute.PropValue}");
                        break;
                    }
                }
                
                Console.WriteLine();
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
