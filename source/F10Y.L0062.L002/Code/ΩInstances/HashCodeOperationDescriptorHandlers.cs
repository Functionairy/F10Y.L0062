using System;


namespace F10Y.L0062.L002
{
    public class HashCodeOperationDescriptorHandlers : IHashCodeOperationDescriptorHandlers
    {
        #region Infrastructure

        public static IHashCodeOperationDescriptorHandlers Instance { get; } = new HashCodeOperationDescriptorHandlers();


        private HashCodeOperationDescriptorHandlers()
        {
        }

        #endregion
    }
}
