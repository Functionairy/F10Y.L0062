using System;


namespace F10Y.L0062.L002
{
    public class SetEqualityOperationDescriptorHandlers : ISetEqualityOperationDescriptorHandlers
    {
        #region Infrastructure

        public static ISetEqualityOperationDescriptorHandlers Instance { get; } = new SetEqualityOperationDescriptorHandlers();


        private SetEqualityOperationDescriptorHandlers()
        {
        }

        #endregion
    }
}
