using System;


namespace F10Y.L0062.L002.T000
{
    public static class Instances
    {
        public static IEqualityOperationDescriptors EqualityOperationDescriptors => T000.EqualityOperationDescriptors.Instance;
        public static L0000.IGuidOperator GuidOperator => L0000.GuidOperator.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
    }
}