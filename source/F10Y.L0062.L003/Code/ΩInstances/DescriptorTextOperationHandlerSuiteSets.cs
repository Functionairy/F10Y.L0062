using System;


namespace F10Y.L0062.L003
{
    public class DescriptorTextOperationHandlerSuiteSets : IDescriptorTextOperationHandlerSuiteSets
    {
        #region Infrastructure

        public static IDescriptorTextOperationHandlerSuiteSets Instance { get; } = new DescriptorTextOperationHandlerSuiteSets();


        private DescriptorTextOperationHandlerSuiteSets()
        {
        }

        #endregion
    }
}
