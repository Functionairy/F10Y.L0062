using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class SetEqualityOperationDescriptorHandlerSuite : DescriptorHandlerSuite<ISetEqualityOperationDescriptor>
    {

    }


    [DataTypeMarker]
    public class SetEqualityOperationDescriptorHandlerSuite<TValue> : DescriptorHandlerSuite<ISetEqualityOperationDescriptor>,
        Synchronous.IBinaryPredicateProviderHandlerSuite<ISetEqualityOperationDescriptor, TValue>
    {
        public Func<ISetEqualityOperationDescriptor, Func<TValue, TValue, bool>> Get_Predicate { get; set; }
    }
}
