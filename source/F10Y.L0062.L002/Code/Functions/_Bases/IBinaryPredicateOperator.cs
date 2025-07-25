using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Bases
{
    [FunctionsMarker]
    public partial interface IBinaryPredicateOperator<TDescriptor, T>
    {
        Dictionary<Type, BinaryPredicateProviderSuite<TDescriptor, T>> BinaryPredicateProviderSuites_ByType { get; }


        public bool Has_Predicate_Synchronous(
            TDescriptor descriptor,
            out Func<T, T, bool> predicate_OrDefault)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                this.BinaryPredicateProviderSuites_ByType,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? handlerSuite_OrDefault.Get_PredicateProvider_Synchronous(descriptor)
                : default
                ;

            return can_Handle;
        }

        public For_Results.N004.Result<Func<T, T, bool>> Has_Predicate_Synchronous(TDescriptor descriptor)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            var output = new For_Results.N004.Result<Func<T, T, bool>>
            {
                Success = has_Predicate,
                Value = predicate_OrDefault
            };

            return output;
        }

        public Func<T, T, bool> Get_Predicate_Synchronous(TDescriptor descriptor)
        {
            this.Verify_HasPredicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            return predicate_OrDefault;
        }

        public void Verify_HasPredicate_Synchronous(
            TDescriptor descriptor,
            out Func<T, T, bool> predicate_OrDefault)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out predicate_OrDefault);

            if (!has_Predicate)
            {
                throw Instances.ExceptionOperator.Get_NoPredicateProviderFound_ForDescriptorException();
            }
        }
    }
}