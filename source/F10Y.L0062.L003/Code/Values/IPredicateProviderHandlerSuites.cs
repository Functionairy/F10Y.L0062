using System;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IPredicateProviderHandlerSuites
    {
        #region Descriptor Search Descriptors

        //public For_PredicateProviderSuite.PredicateProviderSuite<IDescriptorSearchDescriptor, IDescriptor> For_DescriptorSearchDescriptor_Name_Simple => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<DescriptorSearchDescriptor_Name_Simple>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.DescriptorSearchDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
        //    //Predicate_Asynchronous = ,
        //};

        #endregion

        #region String Search Descriptors

        //public For_PredicateProviderSuite.Synchronous.PredicateProviderHandlerSuite<IStringSearchDescriptor, string> For_StringSearchDescriptor_EqualityOperationDescriptor => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_EqualityOperationDescriptor>(),
        //    Get_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
        //    //Predicate_Asynchronous = ,
        //};

        //public For_PredicateProviderSuite.Synchronous.PredicateProviderHandlerSuite<IStringSearchDescriptor, string> For_StringSearchDescriptor_Equals_Simple => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_Equals_Simple>(),
        //    Get_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple),
        //    //Predicate_Asynchronous = ,
        //};

        #endregion
    }
}
