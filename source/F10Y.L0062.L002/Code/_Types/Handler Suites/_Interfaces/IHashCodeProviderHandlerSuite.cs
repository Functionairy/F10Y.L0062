using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public interface IHashCodeProviderHandlerSuite<THandled>
    {
        Func<THandled, int> Get_HashCode { get; set; }
    }
}
