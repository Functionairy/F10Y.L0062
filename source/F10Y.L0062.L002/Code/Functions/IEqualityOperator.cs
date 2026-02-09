using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperator :
        L0000.IEqualityOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEqualityOperator _L0000 => L0000.EqualityOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        bool Are_Equal(IDescriptor a, IDescriptor b)
            => Instances.DescriptorOperator.Are_Equal_DisallowNull(a, b);
    }
}
