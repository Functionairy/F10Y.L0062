using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorOperator_ForInteger : IEqualityOperationDescriptorOperator_ForInteger
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorOperator_ForInteger Instance { get; } = new EqualityOperationDescriptorOperator_ForInteger();


        private EqualityOperationDescriptorOperator_ForInteger()
        {
        }

        #endregion
    }
}
