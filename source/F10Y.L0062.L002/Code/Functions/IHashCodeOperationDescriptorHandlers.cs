using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IHashCodeOperationDescriptorHandlers
    {
        Func<string, int> Get_HashCodeFor_String(HashCodeOperationDescriptor_Simple descriptor)
            => Instances.HashCodeOperator.Get_HashCode;
    }
}
