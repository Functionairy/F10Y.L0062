using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptors

        public DescriptorTextOperationHandlerSuite<IDescriptor>[] For_Descriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_Descriptor,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorTextOperationHandlerSuite<IDescriptor>>> For_Descriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_Descriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, DescriptorTextOperationHandlerSuite<IDescriptor>> For_Descriptors_ByType => For_Descriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorTextOperationHandlerSuite<IDescriptor>>> For_Descriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_Descriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, DescriptorTextOperationHandlerSuite<IDescriptor>> For_Descriptors_ByTypeName => For_Descriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Equality Operation Descriptors

        public DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>[] For_EqualityOperationDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_EqualityOperationDescriptor_Simple,
            _DescriptorTextOperationHandlerSuites.For_EqualityOperationDescriptor_Simple_WithNot,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>>> For_EqualityOperationDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_EqualityOperationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>> For_EqualityOperationDescriptors_ByType => For_EqualityOperationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>>> For_EqualityOperationDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_EqualityOperationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>> For_EqualityOperationDescriptors_ByTypeName => For_EqualityOperationDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region Set Equality Operation Descriptors

        public DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>[] For_SetEqualityOperationDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_SetEqualityOperationDescriptor_Containment_OfString,
            _DescriptorTextOperationHandlerSuites.For_SetEqualityOperationDescriptor_Intersection_OfString,
            _DescriptorTextOperationHandlerSuites.For_SetEqualityOperationDescriptor_OfString,
        };

        private static readonly Lazy<Dictionary<Type, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>>> For_SetEqualityOperationDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>> For_SetEqualityOperationDescriptors_ByType => For_SetEqualityOperationDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>>> For_SetEqualityOperationDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_SetEqualityOperationDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>> For_SetEqualityOperationDescriptors_ByTypeName => For_SetEqualityOperationDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
