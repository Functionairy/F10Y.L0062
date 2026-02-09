using System;

using F10Y.T0004;


namespace F10Y.L0062.L003
{
    [DataTypeMarker]
    public class StringSearchDescriptorHandlerSuite : L002.DescriptorHandlerSuite<IStringSearchDescriptor>,
        L002.Synchronous.IPredicateProviderHandlerSuite<IStringSearchDescriptor, string>
    {
        public Func<IStringSearchDescriptor, Func<string, bool>> Get_Predicate { get; set; }
    }
}
