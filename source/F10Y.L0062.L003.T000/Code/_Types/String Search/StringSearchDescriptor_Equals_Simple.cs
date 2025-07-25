using System;

using F10Y.T0004;


namespace F10Y.L0062.L003.T000
{
    /// <summary>
    /// A simple equals string search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class StringSearchDescriptor_Equals_Simple : IStringSearchDescriptor
    {
        public string Value { get; set; }
    }
}
