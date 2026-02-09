using System;


namespace F10Y.L0062.L002
{
    public class EqualityOperationDescriptorHandlers : IEqualityOperationDescriptorHandlers
    {
        #region Infrastructure

        public static IEqualityOperationDescriptorHandlers Instance { get; } = new EqualityOperationDescriptorHandlers();


        private EqualityOperationDescriptorHandlers()
        {
        }

        #endregion
    }
}
