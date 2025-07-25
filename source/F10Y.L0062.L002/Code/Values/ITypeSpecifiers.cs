using System;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IDescriptor, Descriptor> For_Descriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDescriptor, Descriptor>.Instance;

        #endregion

        #region Equality Operation Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple> For_EqualityOperationDescriptor_Simple_OfString =>
            For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple_WithNot> For_EqualityOperationDescriptor_Simple_WithNot_OfString =>
            For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple_WithNot>.Instance;

        #endregion

        #region Set Equality Operation Descriptors

        public For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor> For_SetEqualityOperationDescriptor_OfString =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Containment> For_SetEqualityOperationDescriptor_Containment_OfString =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Containment>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Intersection> For_SetEqualityOperationDescriptor_Intersection_OfString =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Intersection>.Instance;

        #endregion
    }
}
