using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorOperator : IEqualityOperationDescriptorOperator
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorOperator Instance { get; } = new EqualityOperationDescriptorOperator();


        private EqualityOperationDescriptorOperator()
        {
        }

        #endregion
    }
}
