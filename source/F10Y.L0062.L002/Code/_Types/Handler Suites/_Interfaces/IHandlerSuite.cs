using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// A handler-suite representation that comes equipped with its identifying type.
    /// </summary>
    [DataTypeMarker]
    public interface IHandlerSuite<TValue>
    {
        TValue Value { get; set; }
    }
}