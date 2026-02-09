using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// A generic type-based handler suite, generic in the handled value.
    /// </summary>
    /// <typeparam name="TValue">The type of the values to be handled.</typeparam>
    [DataTypeMarker]
    public class HandlerSuite<TValue> :
        IHandlerSuite<TValue>,
        IWith_Type
    {
        public Type Type { get; set; }

        public TValue Value { get; set; }
    }
}
