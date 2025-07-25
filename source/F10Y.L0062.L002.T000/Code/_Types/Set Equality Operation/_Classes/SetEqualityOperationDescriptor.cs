using System;

using F10Y.T0004;


namespace F10Y.L0062.L002.T000
{
    /// <summary>
    /// Describes an equality test on two sets.
    /// Allows for order in/dependent testing.
    /// </summary>
    [DataTypeMarker]
    public class SetEqualityOperationDescriptor : SetEqualityOperationDescriptorBase
    {
        public OrderDependence OrderDependence { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class SetEqualityOperationDescriptor : SetEqualityOperationDescriptorBase
        {
            public string OrderDependence { get; set; }
        }
    }
}
