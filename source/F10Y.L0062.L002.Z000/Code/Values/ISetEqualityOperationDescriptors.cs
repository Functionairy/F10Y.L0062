using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.Z000
{
    [ValuesMarker]
    public partial interface ISetEqualityOperationDescriptors
    {
        public For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor_Containment Sub => Instances.SetEqualityOperationDescriptorOperator.From(
            Instances.EqualityOperationDescriptors.Simple,
            Containment.Sub,
            Contiguity.Noncontiguous,
            OrderDependence.OrderIndependent,
            Inclusiveness.Inclusive);

        public For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor_Containment Super => Instances.SetEqualityOperationDescriptorOperator.From(
            Instances.EqualityOperationDescriptors.Simple,
            Containment.Super,
            Contiguity.Noncontiguous,
            OrderDependence.OrderIndependent,
            Inclusiveness.Inclusive);
    }
}
