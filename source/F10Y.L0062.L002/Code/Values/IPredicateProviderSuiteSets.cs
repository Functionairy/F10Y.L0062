using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPredicateProviderSuites _PredicateProviderOperationHandlerSuites => Instances.PredicateProviderSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Equality Operation Descriptors - String

        public BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string>[] For_EqualityOperationDescriptors_OfString => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_EqualityOperationDescriptor_Simple_OfString,
            _PredicateProviderOperationHandlerSuites.For_EqualityOperationDescriptor_Simple_WithNot_OfString,
        };

        private static readonly Lazy<Dictionary<Type, BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string>>> For_EqualityOperationDescriptors_OfString_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_EqualityOperationDescriptors_OfString
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string>> For_EqualityOperationDescriptors_OfString_ByType => For_EqualityOperationDescriptors_OfString_ByType_Lazy.Value;

        #endregion

        #region Set Equality Operation Descriptors - String

        public BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]>[] For_SetEqualityOperationDescriptors_OfString => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_SetEqualityOperationDescriptor_OfString,
            _PredicateProviderOperationHandlerSuites.For_SetEqualityOperationDescriptor_Containment_OfString,
            _PredicateProviderOperationHandlerSuites.For_SetEqualityOperationDescriptor_Intersection_OfString,
        };

        private static readonly Lazy<Dictionary<Type, BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]>>> For_SetEqualityOperationDescriptors_OfString_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_SetEqualityOperationDescriptors_OfString
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]>> For_SetEqualityOperationDescriptors_OfString_ByType => For_SetEqualityOperationDescriptors_OfString_ByType_Lazy.Value;

        #endregion
    }
}
