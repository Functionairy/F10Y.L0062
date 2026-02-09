using System;


namespace F10Y.L0062.L002
{
    public class SetEqualityOperationDescriptorOperator_ForString : ISetEqualityOperationDescriptorOperator_ForString
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptorOperator_ForString Instance { get; } = new SetEqualityOperationDescriptorOperator_ForString();


        private SetEqualityOperationDescriptorOperator_ForString()
        {
        }

        #endregion
    }
}
