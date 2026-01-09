using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPredicateProviderSuites _PredicateProviderOperationHandlerSuites => Instances.PredicateProviderSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptor Search Descriptors

        //public For_PredicateProviderSuite.PredicateProviderSuite<IDescriptorSearchDescriptor, IDescriptor>[] For_DescriptorSearchDescriptors => new[]
        //{
        //    _PredicateProviderOperationHandlerSuites.For_DescriptorSearchDescriptor_Name_Simple,
        //};

        //private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDescriptorSearchDescriptor, IDescriptor>>> For_DescriptorSearchDescriptors_ByType_Lazy = new(() =>
        //    Instances.PredicateProviderSuiteSets.For_DescriptorSearchDescriptors
        //        .ToDictionary(x => x.Type)
        //);

        //public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDescriptorSearchDescriptor, IDescriptor>> For_DescriptorSearchDescriptors_ByType => For_DescriptorSearchDescriptors_ByType_Lazy.Value;

        #endregion

        #region String Search Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IStringSearchDescriptor, string>[] For_StringSearchDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_StringSearchDescriptor_EqualityOperationDescriptor,
            _PredicateProviderOperationHandlerSuites.For_StringSearchDescriptor_Equals_Simple,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IStringSearchDescriptor, string>>> For_StringSearchDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_StringSearchDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IStringSearchDescriptor, string>> For_StringSearchDescriptors_ByType => For_StringSearchDescriptors_ByType_Lazy.Value;

        #endregion
    }
}
