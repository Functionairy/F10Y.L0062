using System;


namespace F10Y.L0062.L002
{
    public class PredicateProviderSuiteSets : IPredicateProviderSuiteSets
    {
        #region Infrastructure

        public static IPredicateProviderSuiteSets Instance { get; } = new PredicateProviderSuiteSets();


        private PredicateProviderSuiteSets()
        {
        }

        #endregion
    }
}
