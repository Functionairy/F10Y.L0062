using System;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptorSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IEqualityOperationDescriptors _EqualityOperationDescriptors => Instances.EqualityOperationDescriptors;

#pragma warning restore IDE1006 // Naming Styles


        public IEqualityOperationDescriptor[] All => new[]
        {
            _EqualityOperationDescriptors.For_String_SimpleWithNot,
        };
    }
}
