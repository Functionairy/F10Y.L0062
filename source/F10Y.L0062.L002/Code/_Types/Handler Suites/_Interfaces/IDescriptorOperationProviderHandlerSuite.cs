using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <inheritdoc cref="L0005.L004.IDescriptorProviderHandlerSuite{THandled}"/>
    [DataTypeMarker]
    public interface IDescriptorOperationProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, Descriptor>> Get_DescriptorOperation { get; set; }
    }
}