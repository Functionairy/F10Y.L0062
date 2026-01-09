using System;


namespace F10Y.L0062.L002
{
    public class HandlerSuites : IHandlerSuites
    {
        #region Infrastructure

        public static IHandlerSuites Instance { get; } = new HandlerSuites();


        private HandlerSuites()
        {
        }

        #endregion
    }
}
