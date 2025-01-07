using System;

namespace AttributeConstructorExample.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class NoParameterAttribute: Attribute
    {
        public NoParameterAttribute()
        {
            CtorValue = "CtorValue from ctor()";

            Console.WriteLine($"{nameof(NoParameterAttribute)}.ctor() -- {CtorValue}");
        }

        public string CtorValue { get; }

        public string PropValue { get; set; } = "PropValue from default";
    }
}
