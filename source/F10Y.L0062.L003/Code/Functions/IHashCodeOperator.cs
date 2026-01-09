using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IHashCodeOperator :
        L002.IHashCodeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L002.IHashCodeOperator _L002 => L002.HashCodeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles

        int Get_HashCode(IDescriptorSearchDescriptor searchDescriptor)
            => Instances.DescriptorSearchDescriptorOperator.Get_HashCode(searchDescriptor);
    }
}
