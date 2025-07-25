using System;

using F10Y.T0004;


namespace F10Y.L0062.L002.T000
{
    /// <summary>
    /// Describes an intersection equality test on two sets.
    /// </summary>
    [DataTypeMarker]
    public class SetEqualityOperationDescriptor_Intersection : SetEqualityOperationDescriptorBase
    {
        /// <summary>
        /// Are there any elements from set A in set B?
        /// Or are there no elements from set A in set B?
        /// </summary>
        public AnyOrNone AnyOrNone { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class SetEqualityOperationDescriptor_Intersection : SetEqualityOperationDescriptorBase
        {
            public string AnyOrNone { get; set; }
        }
    }
}
