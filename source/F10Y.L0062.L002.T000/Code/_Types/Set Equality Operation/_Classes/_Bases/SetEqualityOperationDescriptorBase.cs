using System;

using F10Y.T0004;


namespace F10Y.L0062.L002.T000
{
    [DataTypeMarker]
    public abstract class SetEqualityOperationDescriptorBase : ISetEqualityOperationDescriptor
    {
        public IEqualityOperationDescriptor Element_EqualityOperationDescriptor { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public abstract class SetEqualityOperationDescriptorBase : ISetEqualityOperationDescriptor
        {
            public JsonSerializationObject Element_EqualityOperationDescriptor { get; set; }
        }
    }
}
