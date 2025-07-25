using System;


namespace F10Y.L0062.L002
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
