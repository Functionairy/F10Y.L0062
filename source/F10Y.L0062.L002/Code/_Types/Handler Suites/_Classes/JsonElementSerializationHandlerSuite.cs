using System;
using System.Text.Json;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public class JsonElementSerializationHandlerSuite<THandled> :
        IJsonElementSerializationHandlerSuite<THandled>,
        IWith_Type
    {
        public Type Type { get; set; }

        public Func<THandled, JsonElement> To_JsonElement { get; set; }
        public Func<JsonElement, THandled> From_JsonElement { get; set; }
    }
}
