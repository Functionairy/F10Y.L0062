using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// A generic type-based handler suite, generic in the handled value.
    /// </summary>
    /// <typeparam name="T">The type of the values to be handled.</typeparam>
    [DataTypeMarker]
    public class HandlerSuite<T> :
        IHandlerSuite,
        IWith_Type
    {
        public Type Type { get; set; }

        public T Value { get; set; }
    }
}
