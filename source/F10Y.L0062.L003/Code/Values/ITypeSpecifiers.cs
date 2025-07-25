using System;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region String Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_EqualityOperationDescriptor> For_StringSearchDescriptor_EqualityOperationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_EqualityOperationDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_Equals_Simple> For_StringSearchDescriptor_Equals_Simple =>
            For_TypeSpecifiers.TypeSpecifier<IStringSearchDescriptor, StringSearchDescriptor_Equals_Simple>.Instance;

        #endregion
    }
}
