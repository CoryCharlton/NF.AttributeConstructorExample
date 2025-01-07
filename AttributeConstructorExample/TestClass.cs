using AttributeConstructorExample.Attributes;

namespace AttributeConstructorExample
{
    [NoParameter]
    //[NoParameter(PropValue = "Does this work?")] // This causes a NotSupported exception. Not relevant for now
    [OptionalParameter]
    [OptionalParameter("CtorValue from ctor(string value)")]
    [Simple]
    [FieldParameter]
    [FieldParameter(FieldValue = "Not Default")]
    public class TestClass
    {
    }
}
