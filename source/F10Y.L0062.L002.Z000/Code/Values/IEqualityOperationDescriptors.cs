using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.Z000
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptors
    {
        public For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple For_String_Simple
            => For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple.Instance;

        public For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple_WithNot For_String_SimpleWithNot
            => Instances.EqualityOperationDescriptorOperator.From(true);

        public For_EqualityOperationDescriptors.EqualityOperationDescriptor_Simple_WithNot For_String_SimpleWithoutNot
            => Instances.EqualityOperationDescriptorOperator.From(false);
    }
}
