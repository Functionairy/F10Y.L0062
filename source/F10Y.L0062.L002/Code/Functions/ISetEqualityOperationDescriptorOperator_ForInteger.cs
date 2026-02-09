using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator_ForInteger :
        ISetEqualityOperationDescriptorOperator<int>
    {
        IDictionary<Type, SetEqualityOperationDescriptorHandlerSuite<int[]>> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptorHandlerSuite<int[]>>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_OfInteger_ByType;

        IDictionary<string, SetEqualityOperationDescriptorHandlerSuite<int[]>> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<SetEqualityOperationDescriptorHandlerSuite<int[]>>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_OfInteger_ByTypeName;
    }
}
