using System;


namespace F10Y.L0062.L002
{
    public class SetEqualityOperationDescriptorOperator_ForInteger : ISetEqualityOperationDescriptorOperator_ForInteger
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptorOperator_ForInteger Instance { get; } = new SetEqualityOperationDescriptorOperator_ForInteger();


        private SetEqualityOperationDescriptorOperator_ForInteger()
        {
        }

        #endregion
    }
}
