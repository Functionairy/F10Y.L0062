using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator :
        T000.ISetEqualityOperationDescriptorOperator,
        IDescriptorHandlerSuiteOperator<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.ISetEqualityOperationDescriptorOperator _T000 => T000.SetEqualityOperationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, SetEqualityOperationDescriptorHandlerSuite> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_ByType;

        IDictionary<string, SetEqualityOperationDescriptorHandlerSuite> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<SetEqualityOperationDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_ByTypeName;


        ISetEqualityOperationDescriptorOperator_ForInteger For_Integer => SetEqualityOperationDescriptorOperator_ForInteger.Instance;
        ISetEqualityOperationDescriptorOperator_ForString For_String => SetEqualityOperationDescriptorOperator_ForString.Instance;
    }

    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator<TValue> :
        IDescriptorHandlerSuiteOperator<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptorHandlerSuite<TValue[]>>,
        Synchronous.IBinaryPredicateProviderHandlerSuiteOperator<ISetEqualityOperationDescriptor, TValue[], SetEqualityOperationDescriptorHandlerSuite<TValue[]>>
    {
        
    }
}
