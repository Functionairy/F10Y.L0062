using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IExceptionMessageOperator :
        L0005.L003.IExceptionMessageOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0005.L003.IExceptionMessageOperator _L0005_L003 => L0005.L003.ExceptionMessageOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>No predicate provider found for descriptor.</value></para>
        /// </summary>
        string Get_NoPredicateProviderFound_ForDescriptorExceptionMessage<TDescriptor>(TDescriptor descriptor)
        {
            var typeName = Instances.TypeOperator.Get_TypeName(descriptor);

            var output = $"No predicate provider found for descriptor type '{typeName}'.";
            return output;
        }
    }
}
