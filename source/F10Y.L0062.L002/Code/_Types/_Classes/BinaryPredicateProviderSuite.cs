using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// Provides a predicate for a type based on the type (single type).
    /// </summary>
    [UtilityTypeMarker]
    public class BinaryPredicateProviderSuite<T> :
        IWith_Type
    {
        public Type Type { get; set; }


        public Func<T, Func<T, T, bool>> Get_PredicateProvider_Synchronous { get; set; }

        public Func<T, Func<T, T, Task<bool>>> Get_PredicateProvider_Asynchronous { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on a different type (multiple types).
    /// </summary>
    [UtilityTypeMarker]
    public class BinaryPredicateProviderSuite<TDescriptor, T> :
        IWith_Type
    {
        public Type Type { get; set; }


        public Func<TDescriptor, Func<T, T, bool>> Get_PredicateProvider_Synchronous { get; set; }

        public Func<TDescriptor, Func<T, T, Task<bool>>> Get_PredicateProvider_Asynchronous { get; set; }
    }


    /// <summary>
    /// Provides a predicate for a type based on a different type (multiple types).
    /// </summary>
    [UtilityTypeMarker]
    public class BinaryPredicateProviderSuite<TDescriptor, T1, T2> :
        IWith_Type
    {
        public Type Type { get; set; }


        public Func<TDescriptor, Func<T1, T2, bool>> Get_PredicateProvider_Synchronous { get; set; }

        public Func<TDescriptor, Func<T1, T2, Task<bool>>> Get_PredicateProvider_Asynchronous { get; set; }
    }
}