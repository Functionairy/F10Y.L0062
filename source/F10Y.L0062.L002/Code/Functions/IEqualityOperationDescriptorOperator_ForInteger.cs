using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator_ForInteger :
        IEqualityOperationDescriptorOperator<int>
    {
        IDictionary<Type, EqualityOperationDescriptorHandlerSuite<int>> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IEqualityOperationDescriptor, EqualityOperationDescriptorHandlerSuite<int>>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_OfInteger_ByType;

        IDictionary<string, EqualityOperationDescriptorHandlerSuite<int>> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<EqualityOperationDescriptorHandlerSuite<int>>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_EqualityOperationDescriptors_OfInteger_ByTypeName;
    }
}
