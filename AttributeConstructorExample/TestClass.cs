using AttributeConstructorExample.Attributes;

namespace AttributeConstructorExample
{
    [NoParameter]
    [OptionalParameter]
    [OptionalParameter("CtorValue from ctor(string value)")]
    public class TestClass
    {
    }
}
