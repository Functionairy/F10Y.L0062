using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator :
        L0005.L004.IDescriptorOperator,
        IDescriptorHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0005.L004.IDescriptorOperator _L0005_L004 => L0005.L004.DescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, DescriptorHandlerSuite> For_HandlerSuites.TypeBased.IHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_Descriptors_ByType;

        IDictionary<string, DescriptorHandlerSuite> For_HandlerSuites.TypeNameBased.IHandlerSuiteOperator<DescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationTypeName
            => Instances.HandlerSuiteSets.For_Descriptors_ByTypeName;
    }
}
