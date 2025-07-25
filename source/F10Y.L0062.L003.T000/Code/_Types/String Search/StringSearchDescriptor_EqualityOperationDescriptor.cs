using System;

using F10Y.T0004;


namespace F10Y.L0062.L003.T000
{
    /// <summary>
    /// A simple equals string search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class StringSearchDescriptor_EqualityOperationDescriptor : IStringSearchDescriptor
    {
        public For_EqualityOperationDescriptor.IEqualityOperationDescriptor EqualityOperationDescriptor { get; set; }

        public string Value { get; set; }
    }


    namespace Serialization
    {
        /// <inheritdoc cref="StringSearchDescriptor_EqualityOperationDescriptor"/>
        [DataTypeMarker]
        public class StringSearchDescriptor_EqualityOperationDescriptor : IStringSearchDescriptor
        {
            public JsonSerializationObject EqualityOperationDescriptor { get; set; }

            public string Value { get; set; }
        }
    }
}
