using System;

using F10Y.T0004;


namespace F10Y.L0062.L002.T000
{
    /// <summary>
    /// Describes an containment equality test on two sets.
    /// (Is set A a sub/super set of set B?)s
    /// Allows for order in/dependent testing.
    /// </summary>
    [DataTypeMarker]
    public class SetEqualityOperationDescriptor_Containment : SetEqualityOperationDescriptorBase
    {
        /// <summary>
        /// Is set B a subset or superset of set A in Is_{Sub, Super}set(A, B)?
        /// </summary>
        public Containment Containment { get; set; }

        /// <summary>
        /// Is set A contiguously within set B?
        /// Note: order dependence is a separate 
        /// </summary>
        public Contiguity Contiguity { get; set; }

        /// <summary>
        /// Inclusive (element count can be equal-to) or exclusive (element count must not be equal-to) of set equality.
        /// </summary>
        public Inclusiveness Inclusiveness { get; set; }

        /// <summary>
        /// Is set A within set B, in the same order?
        /// </summary>
        public OrderDependence OrderDependence { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class SetEqualityOperationDescriptor_Containment : SetEqualityOperationDescriptorBase
        {
            public string Containment { get; set; }
            public string Contiguity { get; set; }
            public string Inclusiveness { get; set; }
            public string OrderDependence { get; set; }
        }
    }
}
