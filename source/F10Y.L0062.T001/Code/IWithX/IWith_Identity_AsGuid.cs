using System;

using F10Y.T0009;


namespace F10Y.L0062.T001
{
    [WithXMarker]
    public interface IWith_Identity_AsGuid :
        IHas_Identity_AsGuid
    {
        new Guid Identity { get; set; }
    }
}
