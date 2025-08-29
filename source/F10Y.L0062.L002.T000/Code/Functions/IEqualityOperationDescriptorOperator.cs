using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.T000
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator
    {
        public EqualityOperationDescriptor_Simple_WithNot From(bool not)
        {
            var output = new EqualityOperationDescriptor_Simple_WithNot
            {
                Not = not,
            };

            return output;
        }

        /// <summary>
        /// Returns the <see cref="IEqualityOperationDescriptors.Simple"/> instance.
        /// </summary>
        public EqualityOperationDescriptor_Simple Simple()
            => Instances.EqualityOperationDescriptors.Simple;
    }
}
