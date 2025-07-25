using System;
using System.Text.Json;

using F10Y.T0009;


namespace F10Y.L0062.T001
{
    [WithXMarker]
    public interface IWith_Value_AsJsonElement :
        IHas_Value_AsJsonElement
    {
        new JsonElement Value { get; set; }
    }
}
