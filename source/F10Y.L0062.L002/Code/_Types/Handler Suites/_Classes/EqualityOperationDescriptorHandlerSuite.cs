using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class EqualityOperationDescriptorHandlerSuite<TValue> : DescriptorHandlerSuite<IEqualityOperationDescriptor>,
        Synchronous.IBinaryPredicateProviderHandlerSuite<IEqualityOperationDescriptor, TValue>
    {
        public Func<IEqualityOperationDescriptor, Func<TValue, TValue, bool>> Get_Predicate { get; set; }
    }

    [DataTypeMarker]
    public class EqualityOperationDescriptorHandlerSuite : DescriptorHandlerSuite<IEqualityOperationDescriptor>
    {

    }
}
