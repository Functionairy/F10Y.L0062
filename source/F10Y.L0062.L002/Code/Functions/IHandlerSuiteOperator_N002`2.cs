using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002.N002
{
    /// <summary>
    /// Contains functions for working with dictionaries typed by type name (string).
    /// (Useful for per-type lookups.)
    /// </summary>
    [FunctionsMarker]
    public partial interface IHandlerSuiteOperator<THandlerSuite> :
        IHandlerSuiteOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        IHandlerSuiteOperator _HandlerSuiteOperator => HandlerSuiteOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles



        IDictionary<string, THandlerSuite> HandlerSuites_ByHandledTypeName { get; }


        bool Can_Handle(
            string typeName,
            out THandlerSuite handlerSuite_OrDefault)
            => this.Can_Handle(
                typeName,
                this.HandlerSuites_ByHandledTypeName,
                out handlerSuite_OrDefault);

        THandlerSuite Verify_CanHandle(string descriptorTypeName)
            => this.Verify_CanHandle(
                descriptorTypeName,
                this.HandlerSuites_ByHandledTypeName);
    }
}
