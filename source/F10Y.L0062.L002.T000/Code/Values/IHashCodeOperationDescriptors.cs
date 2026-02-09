using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.T000
{
    [ValuesMarker]
    public partial interface IHashCodeOperationDescriptors
    {
        /// <inheritdoc cref="HashCodeOperationDescriptor_Simple"/>
        HashCodeOperationDescriptor_Simple Simple => HashCodeOperationDescriptor_Simple.Instance;
    }
}
