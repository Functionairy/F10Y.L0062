using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IEqualityOperator :
        L002.IEqualityOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L002.IEqualityOperator _L002 => L002.EqualityOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        bool Are_Equal(IDescriptorSearchDescriptor a, IDescriptorSearchDescriptor b)
            => Instances.DescriptorSearchDescriptorOperator.Are_Equal_DisallowNull(a, b);
    }
}
