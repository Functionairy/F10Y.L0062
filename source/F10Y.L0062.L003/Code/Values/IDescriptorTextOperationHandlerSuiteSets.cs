using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDescriptorTextOperationHandlerSuites _DescriptorTextOperationHandlerSuites => Instances.DescriptorTextOperationHandlerSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptor Search Descriptors

        //public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>[] For_DescriptorSearchDescriptors => new[]
        //{
        //    _DescriptorTextOperationHandlerSuites.For_DescriptorSearchDescriptor_Name_Simple,
        //};

        //private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>>> For_DescriptorSearchDescriptors_ByType_Lazy = new(() =>
        //    DescriptorTextOperationHandlerSuiteSets.Instance.For_DescriptorSearchDescriptors
        //        .ToDictionary(x => x.Type)
        //);

        //public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>> For_DescriptorSearchDescriptors_ByType => For_DescriptorSearchDescriptors_ByType_Lazy.Value;

        //private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>>> For_DescriptorSearchDescriptors_ByTypeName_Lazy = new(() =>
        //    DescriptorTextOperationHandlerSuiteSets.Instance.For_DescriptorSearchDescriptors_ByType
        //        .ToDictionary(
        //            pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
        //            pair => pair.Value)
        //);

        //public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>> For_DescriptorSearchDescriptors_ByTypeName => For_DescriptorSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion

        #region String Search Descriptors

        public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>[] For_StringSearchDescriptors => new[]
        {
            _DescriptorTextOperationHandlerSuites.For_StringSearchDescriptor_EqualityOperationDescriptor,
            _DescriptorTextOperationHandlerSuites.For_StringSearchDescriptor_Equals_Simple,
        };

        private static readonly Lazy<Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>>> For_StringSearchDescriptors_ByType_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_StringSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>> For_StringSearchDescriptors_ByType => For_StringSearchDescriptors_ByType_Lazy.Value;

        private static readonly Lazy<Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>>> For_StringSearchDescriptors_ByTypeName_Lazy = new(() =>
            DescriptorTextOperationHandlerSuiteSets.Instance.For_StringSearchDescriptors_ByType
                .ToDictionary(
                    pair => Instances.TypeNameOperator.Get_TypeName(pair.Key),
                    pair => pair.Value)
        );

        public Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>> For_StringSearchDescriptors_ByTypeName => For_StringSearchDescriptors_ByTypeName_Lazy.Value;

        #endregion
    }
}
