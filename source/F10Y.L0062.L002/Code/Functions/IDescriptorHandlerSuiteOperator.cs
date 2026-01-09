using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IDescriptorHandlerSuiteOperator<TDescriptor, TDescriptorHandlerSuite> :
        Synchronous.IEqualityPredicateProviderHandlerSuiteOperator<TDescriptor, TDescriptorHandlerSuite>,
        IHashCodeProviderHandlerSuiteOperator<TDescriptor, TDescriptorHandlerSuite>,
        IJsonElementSerializationHandlerSuiteOperator<TDescriptor, TDescriptorHandlerSuite>,
        ITextSerializationHandlerSuiteOperator<TDescriptor, TDescriptorHandlerSuite>
        where TDescriptorHandlerSuite :
            Synchronous.IEqualityPredicateProviderHandlerSuite<TDescriptor>,
            IHashCodeProviderHandlerSuite<TDescriptor>,
            IJsonElementSerializationHandlerSuite<TDescriptor>,
            ITextSerializationHandlerSuite<TDescriptor>
    {

    }
}
