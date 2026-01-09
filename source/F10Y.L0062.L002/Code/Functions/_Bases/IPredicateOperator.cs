using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002.Bases
{
    /// <summary>
    /// OBSOLETE
    /// </summary>
    /// <typeparam name="TDescriptor"></typeparam>
    [FunctionsMarker]
    public partial interface IPredicateOperator<TDescriptor>
    {
        Dictionary<Type, PredicateProviderSuite<TDescriptor>> PredicateProviderSuites_ByType { get; }


        bool Has_Predicate_Synchronous(
            TDescriptor descriptor,
            out Func<TDescriptor, bool> predicate_OrDefault)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                this.PredicateProviderSuites_ByType,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? handlerSuite_OrDefault.Get_PredicateProvider_Synchronous(descriptor)
                : default
                ;

            return can_Handle;
        }

        For_Results.N004.Result<Func<TDescriptor, bool>> Has_Predicate_Synchronous(TDescriptor descriptor)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            var output = new For_Results.N004.Result<Func<TDescriptor, bool>>
            {
                Success = has_Predicate,
                Value = predicate_OrDefault
            };

            return output;
        }
    }


    /// <summary>
    /// OBSOLETE
    /// </summary>
    [FunctionsMarker]
    public partial interface IPredicateOperator<TDescriptor, T>
    {
        Dictionary<Type, PredicateProviderSuite<TDescriptor, T>> PredicateProviderSuites_ByType { get; }


        bool Has_Predicate_Synchronous(
            TDescriptor descriptor,
            out Func<T, bool> predicate_OrDefault)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                predicate_OrDefault = default;

                return false;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                this.PredicateProviderSuites_ByType,
                out var handlerSuite_OrDefault);

            predicate_OrDefault = can_Handle
                ? handlerSuite_OrDefault.Get_PredicateProvider_Synchronous(descriptor)
                : default
                ;

            return can_Handle;
        }

        For_Results.N004.Result<Func<T, bool>> Has_Predicate_Synchronous(TDescriptor descriptor)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            var output = new For_Results.N004.Result<Func<T, bool>>
            {
                Success = has_Predicate,
                Value = predicate_OrDefault
            };

            return output;
        }

        Func<T, bool> Get_Predicate_Synchronous(TDescriptor descriptor)
        {
            this.Verify_HasPredicate_Synchronous(
                descriptor,
                out var predicate_OrDefault);

            return predicate_OrDefault;
        }

        void Verify_HasPredicate_Synchronous(
            TDescriptor descriptor,
            out Func<T, bool> predicate_OrDefault)
        {
            var has_Predicate = this.Has_Predicate_Synchronous(
                descriptor,
                out predicate_OrDefault);

            if (!has_Predicate)
            {
                throw Instances.ExceptionOperator.Get_NoPredicateProviderFound_ForDescriptorException(descriptor);
            }
        }
    }
}