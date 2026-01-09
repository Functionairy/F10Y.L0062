using System;
using System.Collections.Generic;
using System.Text.Json;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class DescriptorHandlerSuite : DescriptorHandlerSuite<IDescriptor>
    {

    }


    [DataTypeMarker]
    public class DescriptorHandlerSuite<TDescriptor> :
        Synchronous.IEqualityPredicateProviderHandlerSuite<TDescriptor>,
        IHashCodeProviderHandlerSuite<TDescriptor>,
        IJsonElementSerializationHandlerSuite<TDescriptor>,
        ITextSerializationHandlerSuite<TDescriptor>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<TDescriptor, TDescriptor, bool> EqualityPredicate { get; set; }

        public Func<TDescriptor, int> Get_HashCode { get; set; }

        public Func<TDescriptor, JsonElement> To_JsonElement { get; set; }
        public Func<JsonElement, TDescriptor> From_JsonElement { get; set; }

        public Func<TDescriptor, IEnumerable<string>> To_Text_ContentOnly { get; set; }
        public Func<TDescriptor, IEnumerable<string>> To_Text { get; set; }
    }
}
