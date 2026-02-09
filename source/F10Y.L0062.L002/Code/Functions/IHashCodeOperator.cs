using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IHashCodeOperator :
        L0000.IHashCodeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IHashCodeOperator _L0000 => L0000.HashCodeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        int Get_HashCode(IDescriptor descriptor)
            => Instances.DescriptorOperator.Get_HashCode_DisallowNull(descriptor);
    }
}
