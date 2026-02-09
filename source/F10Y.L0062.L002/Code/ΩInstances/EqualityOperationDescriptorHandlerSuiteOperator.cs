using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorHandlerSuiteOperator : IEqualityOperationDescriptorHandlerSuiteOperator
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorHandlerSuiteOperator Instance { get; } = new EqualityOperationDescriptorHandlerSuiteOperator();


        private EqualityOperationDescriptorHandlerSuiteOperator()
        {
        }

        #endregion
    }
}
