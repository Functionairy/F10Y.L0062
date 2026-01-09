using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IHandlerSuites _HandlerSuites => Instances.HandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        DescriptorHandlerSuite[] For_Descriptors => new[]
        {
            _HandlerSuites.For_Descriptor,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorHandlerSuite>> For_Descriptors_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_Descriptors
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, DescriptorHandlerSuite> For_Descriptors_ByType => For_Descriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorHandlerSuite>> For_Descriptors_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_Descriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, DescriptorHandlerSuite> For_Descriptors_ByTypeName => For_Descriptors_ByTypeName_Lazy.Value;
    }
}
