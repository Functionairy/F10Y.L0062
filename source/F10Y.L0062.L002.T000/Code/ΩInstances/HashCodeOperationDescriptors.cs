using System;


namespace F10Y.L0062.L002.T000
{
    public class HashCodeOperationDescriptors : IHashCodeOperationDescriptors
    {
        #region Infrastructure

        public static IHashCodeOperationDescriptors Instance { get; } = new HashCodeOperationDescriptors();


        private HashCodeOperationDescriptors()
        {
        }

        #endregion
    }
}
