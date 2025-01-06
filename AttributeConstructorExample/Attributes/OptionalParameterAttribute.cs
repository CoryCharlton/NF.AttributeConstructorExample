using System;

namespace AttributeConstructorExample.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class OptionalParameterAttribute: Attribute
    {
        public OptionalParameterAttribute()
        {
            CtorValue = "CtorValue from ctor()";

            Console.WriteLine($"{nameof(OptionalParameterAttribute)}.ctor() -- {CtorValue}");
        }

        public OptionalParameterAttribute(string value)
        {
            CtorValue = value;
         
            Console.WriteLine($"{nameof(OptionalParameterAttribute)}.ctor({value}) -- {CtorValue}");
        }

        public string CtorValue { get; }

        public string PropValue { get; } = "PropValue from default";
    }
}
