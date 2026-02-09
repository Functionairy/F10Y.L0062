using System;


namespace F10Y.L0062.L003
{
    public class PredicateProviderHandlerSuiteSets : IPredicateProviderHandlerSuiteSets
    {
        #region Infrastructure

        public static IPredicateProviderHandlerSuiteSets Instance { get; } = new PredicateProviderHandlerSuiteSets();


        private PredicateProviderHandlerSuiteSets()
        {
        }

        #endregion
    }
}
