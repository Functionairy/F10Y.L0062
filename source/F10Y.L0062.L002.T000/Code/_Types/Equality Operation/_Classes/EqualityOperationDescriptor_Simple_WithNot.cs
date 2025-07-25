using System;


namespace F10Y.L0062.L002.T000
{
    /// <summary>
    /// An equality operation descriptor allowing a simple equality test to be NOT.
    /// </summary>
    public class EqualityOperationDescriptor_Simple_WithNot : IEqualityOperationDescriptor
    {
        public bool Not { get; set; }
    }
}
