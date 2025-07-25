using System;


namespace F10Y.L0062.L002.Z000
{
    public class EqualityOperationDescriptors : IEqualityOperationDescriptors
    {
        #region Infrastructure

        public static IEqualityOperationDescriptors Instance { get; } = new EqualityOperationDescriptors();


        private EqualityOperationDescriptors()
        {
        }

        #endregion
    }
}
