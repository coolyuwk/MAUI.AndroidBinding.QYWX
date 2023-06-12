using ObjCRuntime;

namespace QyWxBinding
{
    [Native]
    public enum WWKOpenIdType : ulong
    {
        UnKnown = 0,
        User,
        Department
    }

    [Native]
    public enum WWKDiplayNameType : long
    {
        DefaultName = 0,
        LocalName = 1
    }
}
