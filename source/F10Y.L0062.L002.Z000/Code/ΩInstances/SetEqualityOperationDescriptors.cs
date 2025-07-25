using System;


namespace F10Y.L0062.L002.Z000
{
    public class SetEqualityOperationDescriptors : ISetEqualityOperationDescriptors
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptors Instance { get; } = new SetEqualityOperationDescriptors();


        private SetEqualityOperationDescriptors()
        {
        }

        #endregion
    }
}
