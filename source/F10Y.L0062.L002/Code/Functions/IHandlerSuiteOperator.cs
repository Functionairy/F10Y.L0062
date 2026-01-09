using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// Contains functions for working with dictionaries typed by type.
    /// (Useful for per-type lookups.)
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator :
        N001.IHandlerSuiteOperator,
        N002.IHandlerSuiteOperator
    {

    }

    /// <summary>
    /// Contains functions for working with dictionaries typed by type.
    /// (Useful for per-type lookups.)
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N002.IHandlerSuiteOperator<THandlerSuite>
    {

    }
}
