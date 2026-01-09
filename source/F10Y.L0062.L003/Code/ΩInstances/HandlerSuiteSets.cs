using System;


namespace F10Y.L0062.L003
{
    public class HandlerSuiteSets : IHandlerSuiteSets
    {
        #region Infrastructure

        public static IHandlerSuiteSets Instance { get; } = new HandlerSuiteSets();


        private HandlerSuiteSets()
        {
        }

        #endregion
    }
}
