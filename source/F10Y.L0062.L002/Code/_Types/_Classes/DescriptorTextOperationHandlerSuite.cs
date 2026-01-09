using System;
using System.Collections.Generic;
using System.Text.Json;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class DescriptorTextOperationHandlerSuite<TDescriptor> :
        IWith_Type,
        IJsonElementSerializationHandlerSuite<TDescriptor>,
        ITextSerializationHandlerSuite<TDescriptor>
    {
        public Type Type { get; set; }

        public Func<TDescriptor, IEnumerable<string>> To_Text_ContentOnly { get; set; }
        public Func<TDescriptor, IEnumerable<string>> To_Text { get; set; }

        public Func<TDescriptor, JsonElement> To_JsonElement { get; set; }
        public Func<JsonElement, TDescriptor> From_JsonElement { get; set; }
    }
}
