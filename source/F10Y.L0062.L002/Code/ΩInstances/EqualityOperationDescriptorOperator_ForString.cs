using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorOperator_ForString : IEqualityOperationDescriptorOperator_ForString
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorOperator_ForString Instance { get; } = new EqualityOperationDescriptorOperator_ForString();


        private EqualityOperationDescriptorOperator_ForString()
        {
        }

        #endregion
    }
}
