using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IHandlerSuites _HandlerSuites => Instances.HandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptor Search Descriptors

        DescriptorSearchDescriptorHandlerSuite[] For_DescriptorSearchDescriptors => new[]
        {
            _HandlerSuites.For_DescriptorSearchDescriptor_Name_Simple,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorSearchDescriptorHandlerSuite>> For_DescriptorSearchDescriptors_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_DescriptorSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, DescriptorSearchDescriptorHandlerSuite> For_DescriptorSearchDescriptors_ByType => For_DescriptorSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorSearchDescriptorHandlerSuite>> For_DescriptorSearchDescriptors_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_DescriptorSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, DescriptorSearchDescriptorHandlerSuite> For_DescriptorSearchDescriptors_ByTypeName => For_DescriptorSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region String Search Descriptors

        StringSearchDescriptorHandlerSuite[] For_StringSearchDescriptors => new[]
        {
            _HandlerSuites.For_StringSearchDescriptor_EqualityOperationDescriptor,
            _HandlerSuites.For_StringSearchDescriptor_Equals_Simple,
        };

        private static readonly Lazy<Dictionary<Type, StringSearchDescriptorHandlerSuite>> For_StringSearchDescriptors_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_StringSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, StringSearchDescriptorHandlerSuite> For_StringSearchDescriptors_ByType => For_StringSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, StringSearchDescriptorHandlerSuite>> For_StringSearchDescriptors_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_StringSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, StringSearchDescriptorHandlerSuite> For_StringSearchDescriptors_ByTypeName => For_StringSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
