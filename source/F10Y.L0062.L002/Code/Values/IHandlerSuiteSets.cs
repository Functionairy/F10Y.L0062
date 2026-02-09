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


        #region Descriptors

        DescriptorHandlerSuite[] For_Descriptors => new[]
        {
            _HandlerSuites.For_Descriptor,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorHandlerSuite>> For_Descriptors_ByType_Lazy = new Lazy<Dictionary<Type, DescriptorHandlerSuite>>(() =>
            HandlerSuiteSets.Instance.For_Descriptors
                .ToDictionary(x => x.Type)
        );

        IDictionary<Type, DescriptorHandlerSuite> For_Descriptors_ByType => For_Descriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorHandlerSuite>> For_Descriptors_ByTypeName_Lazy = new Lazy<Dictionary<string, DescriptorHandlerSuite>>(() =>
            HandlerSuiteSets.Instance.For_Descriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        IDictionary<string, DescriptorHandlerSuite> For_Descriptors_ByTypeName => For_Descriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Equality Operation Descriptors

        EqualityOperationDescriptorHandlerSuite[] For_EqualityOperationDescriptors => new[]
        {
            _HandlerSuites.For_EqualityOperationDescriptor_Simple,
            _HandlerSuites.For_EqualityOperationDescriptor_Simple_WithNot,
        };

        private static readonly Lazy<Dictionary<Type, EqualityOperationDescriptorHandlerSuite>> For_EqualityOperationDescriptors_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, EqualityOperationDescriptorHandlerSuite> For_EqualityOperationDescriptors_ByType => For_EqualityOperationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, EqualityOperationDescriptorHandlerSuite>> For_EqualityOperationDescriptors_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, EqualityOperationDescriptorHandlerSuite> For_EqualityOperationDescriptors_ByTypeName => For_EqualityOperationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Equality Operation Descriptors - String

        EqualityOperationDescriptorHandlerSuite<string>[] For_EqualityOperationDescriptors_OfString => new[]
        {
            _HandlerSuites.For_EqualityOperationDescriptor_Simple_OfString,
            _HandlerSuites.For_EqualityOperationDescriptor_Simple_WithNot_OfString,
        };

        private static readonly Lazy<Dictionary<Type, EqualityOperationDescriptorHandlerSuite<string>>> For_EqualityOperationDescriptors_OfString_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors_OfString
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, EqualityOperationDescriptorHandlerSuite<string>> For_EqualityOperationDescriptors_OfString_ByType => For_EqualityOperationDescriptors_OfString_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, EqualityOperationDescriptorHandlerSuite<string>>> For_EqualityOperationDescriptors_OfString_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors_OfString_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, EqualityOperationDescriptorHandlerSuite<string>> For_EqualityOperationDescriptors_OfString_ByTypeName => For_EqualityOperationDescriptors_OfString_ByTypeName_Lazy.Value;

        #endregion

        #region Equality Operation Descriptors - Integer

        EqualityOperationDescriptorHandlerSuite<int>[] For_EqualityOperationDescriptors_OfInteger => new[]
        {
            _HandlerSuites.For_EqualityOperationDescriptor_Simple_OfInteger,
            _HandlerSuites.For_EqualityOperationDescriptor_Simple_WithNot_OfInteger,
        };

        private static readonly Lazy<Dictionary<Type, EqualityOperationDescriptorHandlerSuite<int>>> For_EqualityOperationDescriptors_OfInteger_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors_OfInteger
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, EqualityOperationDescriptorHandlerSuite<int>> For_EqualityOperationDescriptors_OfInteger_ByType => For_EqualityOperationDescriptors_OfInteger_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, EqualityOperationDescriptorHandlerSuite<int>>> For_EqualityOperationDescriptors_OfInteger_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_EqualityOperationDescriptors_OfInteger_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, EqualityOperationDescriptorHandlerSuite<int>> For_EqualityOperationDescriptors_OfInteger_ByTypeName => For_EqualityOperationDescriptors_OfInteger_ByTypeName_Lazy.Value;

        #endregion

        #region Hash Code Operation Descriptors - String

        HashCodeOperationDescriptorHandlerSuite<string>[] For_HashCodeOperationDescriptors_OfString => new[]
        {
            _HandlerSuites.For_HashCodeOperationDescriptor_Simple
        };

        private static readonly Lazy<Dictionary<Type, HashCodeOperationDescriptorHandlerSuite<string>>> For_HashCodeOperationDescriptors_OfString_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_HashCodeOperationDescriptors_OfString
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, HashCodeOperationDescriptorHandlerSuite<string>> For_HashCodeOperationDescriptors_OfString_ByType => For_HashCodeOperationDescriptors_OfString_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, HashCodeOperationDescriptorHandlerSuite<string>>> For_HashCodeOperationDescriptors_OfString_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_HashCodeOperationDescriptors_OfString_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, HashCodeOperationDescriptorHandlerSuite<string>> For_HashCodeOperationDescriptors_OfString_ByTypeName => For_HashCodeOperationDescriptors_OfString_ByTypeName_Lazy.Value;

        #endregion

        #region Set Equality Operation Descriptors

        SetEqualityOperationDescriptorHandlerSuite[] For_SetEqualityOperationDescriptors => new[]
        {
            _HandlerSuites.For_SetEqualityOperationDescriptor_Containment,
            _HandlerSuites.For_SetEqualityOperationDescriptor_Intersection,
            _HandlerSuites.For_SetEqualityOperationDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite>> For_SetEqualityOperationDescriptors_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite> For_SetEqualityOperationDescriptors_ByType => For_SetEqualityOperationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, SetEqualityOperationDescriptorHandlerSuite>> For_SetEqualityOperationDescriptors_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, SetEqualityOperationDescriptorHandlerSuite> For_SetEqualityOperationDescriptors_ByTypeName => For_SetEqualityOperationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Set Equality Operation Descriptors - Integer

        SetEqualityOperationDescriptorHandlerSuite<int[]>[] For_SetEqualityOperationDescriptors_OfInteger => new[]
        {
            _HandlerSuites.For_SetEqualityOperationDescriptor_Containment_OfInteger,
            _HandlerSuites.For_SetEqualityOperationDescriptor_Intersection_OfInteger,
            _HandlerSuites.For_SetEqualityOperationDescriptor_OfInteger,
        };

        private static readonly Lazy<Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite<int[]>>> For_SetEqualityOperationDescriptors_OfInteger_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_OfInteger
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite<int[]>> For_SetEqualityOperationDescriptors_OfInteger_ByType => For_SetEqualityOperationDescriptors_OfInteger_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, SetEqualityOperationDescriptorHandlerSuite<int[]>>> For_SetEqualityOperationDescriptors_OfInteger_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_OfInteger_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, SetEqualityOperationDescriptorHandlerSuite<int[]>> For_SetEqualityOperationDescriptors_OfInteger_ByTypeName => For_SetEqualityOperationDescriptors_OfInteger_ByTypeName_Lazy.Value;

        #endregion

        #region Set Equality Operation Descriptors - String

        SetEqualityOperationDescriptorHandlerSuite<string[]>[] For_SetEqualityOperationDescriptors_OfString => new[]
        {
            _HandlerSuites.For_SetEqualityOperationDescriptor_Containment_OfString,
            _HandlerSuites.For_SetEqualityOperationDescriptor_Intersection_OfString,
            _HandlerSuites.For_SetEqualityOperationDescriptor_OfString,
        };

        private static readonly Lazy<Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite<string[]>>> For_SetEqualityOperationDescriptors_OfString_ByType_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_OfString
                .ToDictionary(x => x.Type)
        );

        Dictionary<Type, SetEqualityOperationDescriptorHandlerSuite<string[]>> For_SetEqualityOperationDescriptors_OfString_ByType => For_SetEqualityOperationDescriptors_OfString_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, SetEqualityOperationDescriptorHandlerSuite<string[]>>> For_SetEqualityOperationDescriptors_OfString_ByTypeName_Lazy = new(() =>
            HandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_OfString_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        Dictionary<string, SetEqualityOperationDescriptorHandlerSuite<string[]>> For_SetEqualityOperationDescriptors_OfString_ByTypeName => For_SetEqualityOperationDescriptors_OfString_ByTypeName_Lazy.Value;

        #endregion
    }
}
