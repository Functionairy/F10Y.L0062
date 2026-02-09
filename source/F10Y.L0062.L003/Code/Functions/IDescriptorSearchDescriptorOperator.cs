using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IDescriptorSearchDescriptorOperator :
        T000.IDescriptorSearchDescriptorOperator,
        L002.ISearchDescriptorHandlerSuiteOperator<IDescriptorSearchDescriptor, IDescriptor, DescriptorSearchDescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        T000.IDescriptorSearchDescriptorOperator _T000 => T000.DescriptorSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, DescriptorSearchDescriptorHandlerSuite> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IDescriptorSearchDescriptor, DescriptorSearchDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_DescriptorSearchDescriptors_ByType;

        IDictionary<string, DescriptorSearchDescriptorHandlerSuite> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<DescriptorSearchDescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_DescriptorSearchDescriptors_ByTypeName;
    }
}
