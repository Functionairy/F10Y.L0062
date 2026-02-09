using System;

using F10Y.T0003;


namespace F10Y.L0062.L002.Z000
{
    [ValuesMarker]
    public partial interface ISetEqualityOperationDescriptors
    {
        For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor Simple => Instances.SetEqualityOperationDescriptorOperator.From_OrderIndependent(
            Instances.EqualityOperationDescriptors.Simple);

        For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor OrderIndependent => Instances.SetEqualityOperationDescriptorOperator.From_OrderIndependent(
            Instances.EqualityOperationDescriptors.Simple);

        For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor OrderDependent => Instances.SetEqualityOperationDescriptorOperator.From_OrderDependent(
            Instances.EqualityOperationDescriptors.Simple);

        /// <summary>
        /// Set B is a subset of set A in Is_Subset(A, B).
        /// </summary>
        For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor_Containment BSubsetOfA => Instances.SetEqualityOperationDescriptorOperator.From(
            Instances.EqualityOperationDescriptors.Simple,
            Containment.Sub,
            Contiguity.Noncontiguous,
            OrderDependence.OrderIndependent,
            Inclusiveness.Inclusive);

        /// <summary>
        /// Set B is a superset of set A in Is_Superset(A, B).
        /// </summary>
        For_SetEqualityOperationDescriptors.SetEqualityOperationDescriptor_Containment BSupersetOfA => Instances.SetEqualityOperationDescriptorOperator.From(
            Instances.EqualityOperationDescriptors.Simple,
            Containment.Super,
            Contiguity.Noncontiguous,
            OrderDependence.OrderIndependent,
            Inclusiveness.Inclusive);
    }
}
