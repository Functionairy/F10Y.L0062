using System;

using F10Y.T0009;


namespace F10Y.L0062.T001
{
    [WithXMarker]
    public interface IWith_TypeName :
        IHas_TypeName
    {
        new string TypeName { get; set; }
    }
}
