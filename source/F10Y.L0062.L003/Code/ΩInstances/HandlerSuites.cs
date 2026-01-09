using System;


namespace F10Y.L0062.L003
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
