using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L0001.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0001.IGuidOperator _F10Y_L0001 => L0001.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        string To_String_ForDescriptor(Guid guid)
        {
            var output = this.To_String_Standard(guid);
            return output;
        }
    }
}
