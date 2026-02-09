using System;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class SearchDescriptorHandlerSuite<TSearchDescriptor, TDescriptor> : DescriptorHandlerSuite<TSearchDescriptor>,
        Synchronous.IPredicateHandlerSuite<TSearchDescriptor, TDescriptor>
    {
        public Func<TSearchDescriptor, TDescriptor, bool> Predicate { get; set; }
    }
}
