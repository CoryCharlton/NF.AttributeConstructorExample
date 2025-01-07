using System;

namespace AttributeConstructorExample.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class FieldParameterAttribute : Attribute
    {
        public FieldParameterAttribute()
        {
            Console.WriteLine($"{nameof(NoParameterAttribute)}.ctor() -- {FieldValue}");
        }

        public string FieldValue = "Default";
    }
}
