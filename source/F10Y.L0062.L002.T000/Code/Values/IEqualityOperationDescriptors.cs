using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.T000
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptors
    {
        /// <summary>
        /// Returns the <see cref="EqualityOperationDescriptor_Simple.Instance"/> instance.
        /// </summary>
        public EqualityOperationDescriptor_Simple Simple
            => EqualityOperationDescriptor_Simple.Instance;
    }
}
