using System;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuites
    {
        #region Equality Operation Descriptor - String

        //public BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string> For_EqualityOperationDescriptor_Simple_OfString => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.EqualityOperationDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_OfString),
        //    //Predicate_Asynchronous = ,
        //};

        //public BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string> For_EqualityOperationDescriptor_Simple_WithNot_OfString => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple_WithNot>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.EqualityOperationDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot_OfString),
        //    //Predicate_Asynchronous = ,
        //};

        #endregion

        #region Set Equality Operation Descriptor - String Array

        //public BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]> For_SetEqualityOperationDescriptor_OfString => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.SetEqualityOperationDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_OfString),
        //    //Predicate_Asynchronous = ,
        //};


        //public BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]> For_SetEqualityOperationDescriptor_Containment_OfString => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Containment>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.SetEqualityOperationDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment_OfString),
        //    //Predicate_Asynchronous = ,
        //};
        //public BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]> For_SetEqualityOperationDescriptor_Intersection_OfString => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Intersection>(),
        //    Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.SetEqualityOperationDescriptorOperator.Get_PredicateFor,
        //        Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection_OfString),
        //    //Predicate_Asynchronous = ,
        //};

        #endregion
    }
}
