using System;

using F10Y.T0004;


namespace F10Y.L0062.L002.T000
{
    [DataTypeMarker]
    public interface IDescriptor :
        IHas_Identity_AsGuid,
        IHas_Name,
        IHas_Description
    {
    }
}
