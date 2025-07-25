using System;
using System.Text.Json;

using F10Y.T0009;


namespace F10Y.L0062.T001
{
    [HasXMarker]
    public interface IHas_Value_AsJsonElement
    {
        JsonElement Value { get; }
    }
}
