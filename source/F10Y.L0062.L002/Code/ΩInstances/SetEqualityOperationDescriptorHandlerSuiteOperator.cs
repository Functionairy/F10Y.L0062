using System;


namespace F10Y.L0062.L002
{
    public class SetEqualityOperationDescriptorHandlerSuiteOperator : ISetEqualityOperationDescriptorHandlerSuiteOperator
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptorHandlerSuiteOperator Instance { get; } = new SetEqualityOperationDescriptorHandlerSuiteOperator();


        private SetEqualityOperationDescriptorHandlerSuiteOperator()
        {
        }

        #endregion
    }
}
