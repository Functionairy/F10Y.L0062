using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IExceptionOperator :
        L0000.IExceptionOperator,
        L0005.L003.IExceptionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        new L0000.IExceptionOperator _L0000 => L0000.ExceptionOperator.Instance;

        [Ignore]
        L0005.L003.IExceptionOperator _L0005_L003 => L0005.L003.ExceptionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Exception Get_NoHandlerSuiteFoundForDescriptorTypeException(string implementationType_TypeName)
        {
            var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(implementationType_TypeName);

            var output = this.From(message);
            return output;
        }

        Exception Get_NoPredicateProviderFound_ForDescriptorException()
        {
            var message = Instances.ExceptionMessages.NoPredicateProviderFound_ForDescriptor;

            var output = this.From(message);
            return output;
        }

        Exception Get_NoPredicateProviderFound_ForDescriptorException<TDescriptor>(TDescriptor descriptor)
        {
            var message = Instances.ExceptionMessageOperator.Get_NoPredicateProviderFound_ForDescriptorExceptionMessage(descriptor);

            var output = this.From(message);
            return output;
        }
    }
}
