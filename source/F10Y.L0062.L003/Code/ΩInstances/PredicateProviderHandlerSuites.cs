using System;


namespace F10Y.L0062.L003
{
    public class PredicateProviderHandlerSuites : IPredicateProviderHandlerSuites
    {
        #region Infrastructure

        public static IPredicateProviderHandlerSuites Instance { get; } = new PredicateProviderHandlerSuites();


        private PredicateProviderHandlerSuites()
        {
        }

        #endregion
    }
}
