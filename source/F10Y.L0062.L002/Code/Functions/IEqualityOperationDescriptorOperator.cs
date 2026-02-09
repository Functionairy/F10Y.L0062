using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator :
        T000.IEqualityOperationDescriptorOperator,
        IDescriptorHandlerSuiteOperator<IEqualityOperationDescriptor, EqualityOperationDescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IEqualityOperationDescriptorOperator _T000 => T000.EqualityOperationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, EqualityOperationDescriptorHandlerSuite> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IEqualityOperationDescriptor, EqualityOperationDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_ByType;

        IDictionary<string, EqualityOperationDescriptorHandlerSuite> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<EqualityOperationDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_ByTypeName;


        IEqualityOperationDescriptorOperator_ForInteger For_Integer => EqualityOperationDescriptorOperator_ForInteger.Instance;
        IEqualityOperationDescriptorOperator_ForString For_String => EqualityOperationDescriptorOperator_ForString.Instance;
    }


    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator<TValue> :
        IDescriptorHandlerSuiteOperator<IEqualityOperationDescriptor, EqualityOperationDescriptorHandlerSuite<TValue>>,
        Synchronous.IBinaryPredicateProviderHandlerSuiteOperator<IEqualityOperationDescriptor, TValue, EqualityOperationDescriptorHandlerSuite<TValue>>
    {
        
    }
}
