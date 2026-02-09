using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers :
        L0005.L004.ITypeSpecifiers
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0005.L004.ITypeSpecifiers _L0005_L004 => L0005.L004.TypeSpecifiers.Instance;

#pragma warning restore IDE1006 // Naming Styles


        #region Equality Operation Descriptors

        For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor> For_IEqualityOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple> For_EqualityOperationDescriptor_Simple =>
            For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple_WithNot> For_EqualityOperationDescriptor_Simple_WithNot =>
            For_TypeSpecifiers.TypeSpecifier<IEqualityOperationDescriptor, EqualityOperationDescriptor_Simple_WithNot>.Instance;

        #endregion

        #region Hash Code Operation Descriptors

        For_TypeSpecifiers.TypeSpecifier<IHashCodeOperationDescriptor> For_IHashCodeOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IHashCodeOperationDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IHashCodeOperationDescriptor, HashCodeOperationDescriptor_Simple> For_HashCodeOperationDescriptor_Simple =>
            For_TypeSpecifiers.TypeSpecifier<IHashCodeOperationDescriptor, HashCodeOperationDescriptor_Simple>.Instance;

        #endregion

        #region Set Equality Operation Descriptors

        For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor> For_ISetEqualityOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor> For_SetEqualityOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Containment> For_SetEqualityOperationDescriptor_Containment =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Containment>.Instance;

        For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Intersection> For_SetEqualityOperationDescriptor_Intersection =>
            For_TypeSpecifiers.TypeSpecifier<ISetEqualityOperationDescriptor, SetEqualityOperationDescriptor_Intersection>.Instance;

        #endregion
    }
}
