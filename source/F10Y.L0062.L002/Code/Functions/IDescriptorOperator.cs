using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator :
        T000.IDescriptorOperator,
        IDescriptorHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IDescriptorOperator _T000 => T000.DescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IDictionary<Type, DescriptorHandlerSuite> N001.IHandlerSuiteOperator<IDescriptor, DescriptorHandlerSuite>.HandlerSuites_ByHandledImplementationType
            => Instances.HandlerSuiteSets.For_Descriptors_ByType;

        IDictionary<string, DescriptorHandlerSuite> N002.IHandlerSuiteOperator<DescriptorHandlerSuite>.HandlerSuites_ByHandledTypeName
            => Instances.HandlerSuiteSets.For_Descriptors_ByTypeName;
    }
}
