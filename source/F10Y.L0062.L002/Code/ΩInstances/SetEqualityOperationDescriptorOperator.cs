using System;


namespace F10Y.L0062.L002
{
    public class SetEqualityOperationDescriptorOperator : ISetEqualityOperationDescriptorOperator
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptorOperator Instance { get; } = new SetEqualityOperationDescriptorOperator();


        private SetEqualityOperationDescriptorOperator()
        {
        }

        #endregion
    }
}
