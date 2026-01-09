using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// A handler-suite representation that comes equipped with its identifying type.
    /// </summary>
    [DataTypeMarker]
    public interface IHandlerSuite :
        N001.IHandlerSuite,
        IHas_Type
    {
    }
}


namespace F10Y.L0062.L002.N001
{
    /// <summary>
    /// An empty handler suite representation.
    /// </summary>
    [DataTypeMarker]
    public interface IHandlerSuite
    {
        // Empty.
    }
}