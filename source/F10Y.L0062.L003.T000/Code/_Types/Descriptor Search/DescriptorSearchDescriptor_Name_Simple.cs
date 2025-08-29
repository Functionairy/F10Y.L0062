using System;

using F10Y.T0004;


namespace F10Y.L0062.L003.T000
{
    /// <summary>
    /// Search <see cref="IDescriptor"/> instances by name, using simple equality.
    /// </summary>
    [DataTypeMarker]
    public class DescriptorSearchDescriptor_Name_Simple : IDescriptorSearchDescriptor
    {
        public string Name { get; set; }
    }
}
