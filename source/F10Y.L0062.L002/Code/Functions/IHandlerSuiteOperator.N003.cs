using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.N003
{
    /// <summary>
    /// Contains functions for working with dictionaries of handler suites keyed by handled type.
    /// (Useful for per-type lookups.)
    /// <para>
    /// This operator contains methods that must be given dictionaries as input arguments.
    /// </para>
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator :
        N001.IHandlerSuiteOperator,
        L0005.L003.TypeNameBased.IHandlerSuiteOperator
    {

    }

    /// <summary>
    /// Contains functions for working with dictionaries of handler suites keyed by handled type and type name.
    /// (Useful for per-type lookups.)
    /// <para>
    /// This provides dictionary properties to methods from <see cref="IHandlerSuiteOperator"/>.
    /// </para>
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandled, THandlerSuite> :
        N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        L0005.L003.TypeNameBased.IHandlerSuiteOperator<THandlerSuite>
    {

    }
}
