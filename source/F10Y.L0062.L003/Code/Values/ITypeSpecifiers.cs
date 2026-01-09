using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers :
        L002.ITypeSpecifiers
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L002.ITypeSpecifiers _L002 => L002.TypeSpecifiers.Instance;

#pragma warning restore IDE1006 // Naming Styles


        #region Descriptor Serach Descriptors

        For_TypeSpecifiers.TypeSpecifier<IDescriptorSearchDescriptor> For_IDescriptorSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IDescriptorSearchDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IDescriptorSearchDescriptor, DescriptorSearchDescriptor_Name_Simple> For_DescriptorSearchDescriptor_Name_Simple =>
            For_TypeSpecifiers.TypeSpecifier<IDescriptorSearchDescriptor, DescriptorSearchDescriptor_Name_Simple>.Instance;

        #endregion

        #region String Search Descriptors

        For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor> For_IStringSearchDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_EqualityOperationDescriptor> For_StringSearchDescriptor_EqualityOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_EqualityOperationDescriptor>.Instance;

        For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_Equals_Simple> For_StringSearchDescriptor_Equals_Simple =>
            For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_Equals_Simple>.Instance;

        #endregion
    }
}
