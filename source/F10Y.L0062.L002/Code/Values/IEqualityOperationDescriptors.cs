using System;

using F10Y.T0003;

using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptors :
        Z000.IEqualityOperationDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IEqualityOperationDescriptors _Z000 => Z000.EqualityOperationDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
