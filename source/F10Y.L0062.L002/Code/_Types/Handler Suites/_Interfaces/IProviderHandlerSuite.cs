using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    /// <summary>
    /// A handler suite for providing values from handled instances.
    /// </summary>
    /// <remarks>
    /// This interface is not useful, since handler suites are defined by their property names.
    /// The answer to whether or not you should have a new handler suite is simply "Does the name of property accurately describe what the handler does?"
    /// This handler suite generally does not; "Get_Provided" is a really undescriptive name!
    /// <para>
    /// However this handler suite is provided as a copy-paste-and-modify example of provider handler suite interfaces.
    /// </para>
    /// </remarks>
    [DataTypeMarker]
    public interface IProviderHandlerSuite<THandled, TProvided>
    {
        Func<THandled, TProvided> Get_Provided { get; set; }
    }
}