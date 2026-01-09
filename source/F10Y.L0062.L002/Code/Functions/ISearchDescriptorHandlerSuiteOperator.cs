using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISearchDescriptorHandlerSuiteOperator<TSearchDescriptor, TDescriptor, TSearchDescriptorHandlerSuite> :
        IDescriptorHandlerSuiteOperator<TSearchDescriptor, TSearchDescriptorHandlerSuite>,
        Synchronous.IPredicateProviderHandlerSuiteOperator<TSearchDescriptor, TDescriptor, TSearchDescriptorHandlerSuite>
        where TSearchDescriptorHandlerSuite :
            Synchronous.IEqualityPredicateProviderHandlerSuite<TSearchDescriptor>,
            IHashCodeProviderHandlerSuite<TSearchDescriptor>,
            IJsonElementSerializationHandlerSuite<TSearchDescriptor>,
            Synchronous.IPredicateProviderHandlerSuite<TSearchDescriptor, TDescriptor>,
            ITextSerializationHandlerSuite<TSearchDescriptor>
    {

    }
}
