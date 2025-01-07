using System;

namespace AttributeConstructorExample.Attributes
{
    public class SimpleAttribute : Attribute
    {
        public SimpleAttribute()
        {
            Console.WriteLine($"{nameof(SimpleAttribute)}.ctor()");
        }
    }
}
