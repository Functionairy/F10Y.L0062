using System;


namespace F10Y.L0062.L002.T000
{
    /// <summary>
    /// A simple equality operation descriptor.
    /// </summary>
    public class EqualityOperationDescriptor_Simple : IEqualityOperationDescriptor
    {
        #region Static

        public static EqualityOperationDescriptor_Simple Instance { get; } = new();

        #endregion
    }
}
