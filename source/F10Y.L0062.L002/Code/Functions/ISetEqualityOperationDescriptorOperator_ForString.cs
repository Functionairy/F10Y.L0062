using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator_ForString :
        ISetEqualityOperationDescriptorOperator<string>
    {
        IDictionary<Type, SetEqualityOperationDescriptorHandlerSuite<string[]>> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptorHandlerSuite<string[]>>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_OfString_ByType;

        IDictionary<string, SetEqualityOperationDescriptorHandlerSuite<string[]>> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<SetEqualityOperationDescriptorHandlerSuite<string[]>>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_SetEqualityOperationDescriptors_OfString_ByTypeName;
    }
}
