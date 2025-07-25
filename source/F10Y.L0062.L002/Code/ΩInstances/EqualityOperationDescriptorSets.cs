using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorSets : IEqualityOperationDescriptorSets
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorSets Instance { get; } = new EqualityOperationDescriptorSets();


        private EqualityOperationDescriptorSets()
        {
        }

        #endregion
    }
}
