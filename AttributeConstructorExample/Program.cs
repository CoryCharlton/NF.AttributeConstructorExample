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
                switch (attribute)
                {
                    case NoParameterAttribute noParameterAttribute:
                    {
                        Console.WriteLine($"-- {noParameterAttribute.GetType()} -- CtorValue: {noParameterAttribute.CtorValue} -- PropValue: {noParameterAttribute.PropValue}");
                        break;
                    }
                    case OptionalParameterAttribute optionalParameterAttribute:
                    {
                        Console.WriteLine($"-- {optionalParameterAttribute.GetType()} -- CtorValue: {optionalParameterAttribute.CtorValue} -- PropValue: {optionalParameterAttribute.PropValue}");
                        break;
                    }
                }
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
