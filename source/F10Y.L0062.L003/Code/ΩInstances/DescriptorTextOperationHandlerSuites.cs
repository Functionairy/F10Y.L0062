using System;


namespace F10Y.L0062.L003
{
    public class DescriptorTextOperationHandlerSuites : IDescriptorTextOperationHandlerSuites
    {
        #region Infrastructure

        public static IDescriptorTextOperationHandlerSuites Instance { get; } = new DescriptorTextOperationHandlerSuites();


        private DescriptorTextOperationHandlerSuites()
        {
        }

        #endregion
    }
}
