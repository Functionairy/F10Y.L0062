using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.T000
{
    [ValuesMarker]
    public partial interface IEqualityOperationDescriptors
    {
        /// <summary>
        /// <inheritdoc cref="EqualityOperationDescriptor_Simple" path="/summary"/>
        /// <para>
        /// Returns the <see cref="EqualityOperationDescriptor_Simple.Instance"/> instance.
        /// </para>
        /// </summary>
        EqualityOperationDescriptor_Simple Simple
            => EqualityOperationDescriptor_Simple.Instance;

        EqualityOperationDescriptor_Simple_WithNot Simple_WithNot
            => Instances.EqualityOperationDescriptorOperator.From(true);

        EqualityOperationDescriptor_Simple_WithNot Simple_WithoutNot
            => Instances.EqualityOperationDescriptorOperator.From(false);
    }
}
