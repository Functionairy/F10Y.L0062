using System;
using System.Text.Json;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public interface IJsonElementSerializationHandlerSuite<THandled>
    {
        Func<THandled, JsonElement> To_JsonElement { get; set; }
        Func<JsonElement, THandled> From_JsonElement { get; set; }
    }
}
