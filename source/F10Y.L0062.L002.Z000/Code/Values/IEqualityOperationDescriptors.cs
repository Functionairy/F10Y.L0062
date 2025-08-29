using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0062.L002.Z000
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptors :
        T000.IEqualityOperationDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IEqualityOperationDescriptors _T000 => T000.EqualityOperationDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple_WithNot Simple_WithNot
            => Instances.EqualityOperationDescriptorOperator.From(true);

        public For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple_WithNot Simple_WithoutNot
            => Instances.EqualityOperationDescriptorOperator.From(false);
    }
}
