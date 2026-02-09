using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class HashCodeOperationDescriptorHandlerSuite<TValue> : DescriptorHandlerSuite<IHashCodeOperationDescriptor>,
        IHashCodeOperationProviderHandlerSuite<IHashCodeOperationDescriptor, TValue>
    {
        public Func<IHashCodeOperationDescriptor, Func<TValue, int>> Get_HashCodeOperation { get; set; }
    }

    [DataTypeMarker]
    public class HashCodeOperationDescriptorHandlerSuite : DescriptorHandlerSuite<IHashCodeOperationDescriptor>
    {

    }
}
