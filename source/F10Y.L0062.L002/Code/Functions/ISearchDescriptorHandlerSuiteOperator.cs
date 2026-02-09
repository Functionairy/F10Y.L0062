using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISearchDescriptorHandlerSuiteOperator<TSearchDescriptor, TDescriptor, TSearchDescriptorHandlerSuite> :
        IDescriptorHandlerSuiteOperator<TSearchDescriptor, TSearchDescriptorHandlerSuite>,
        Synchronous.IPredicateHandlerSuiteOperator<TSearchDescriptor, TDescriptor, TSearchDescriptorHandlerSuite>
        where TSearchDescriptorHandlerSuite :
            Synchronous.IEqualityPredicateHandlerSuite<TSearchDescriptor>,
            IHashCodeProviderHandlerSuite<TSearchDescriptor>,
            IJsonElementSerializationHandlerSuite<TSearchDescriptor>,
            Synchronous.IPredicateHandlerSuite<TSearchDescriptor, TDescriptor>,
            ITextSerializationHandlerSuite<TSearchDescriptor>
    {

    }
}
