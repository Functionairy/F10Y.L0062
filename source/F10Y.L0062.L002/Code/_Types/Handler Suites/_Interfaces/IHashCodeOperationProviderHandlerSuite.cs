using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public interface IHashCodeOperationProviderHandlerSuite<THandled, TValue>
    {
        Func<THandled, Func<TValue, int>> Get_HashCodeOperation { get; set; }
    }
}
