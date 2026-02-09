using System;


namespace F10Y.L0062.L003
{
    public static class Instances
    {
        public static L002.IDescriptorOperator DescriptorOperator => L002.DescriptorOperator.Instance;
        public static IDescriptorSearchDescriptorHandlers DescriptorSearchDescriptorHandlers => L003.DescriptorSearchDescriptorHandlers.Instance;
        public static IDescriptorSearchDescriptorOperator DescriptorSearchDescriptorOperator => L003.DescriptorSearchDescriptorOperator.Instance;
        public static IDescriptorTextOperationHandlerSuites DescriptorTextOperationHandlerSuites => L003.DescriptorTextOperationHandlerSuites.Instance;
        public static IDescriptorTextOperationHandlerSuiteSets DescriptorTextOperationHandlerSuiteSets => L003.DescriptorTextOperationHandlerSuiteSets.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L002.IEqualityOperationDescriptorOperator EqualityOperationDescriptorOperator => L002.EqualityOperationDescriptorOperator.Instance;
        public static IEqualityOperator EqualityOperator => L003.EqualityOperator.Instance;
        public static IHandlerSuites HandlerSuites => L003.HandlerSuites.Instance;
        public static IHandlerSuiteSets HandlerSuiteSets => L003.HandlerSuiteSets.Instance;
        public static IHashCodeOperator HashCodeOperator => L003.HashCodeOperator.Instance;
        public static L0060.IJsonElementOperator JsonElementOperator => L0060.JsonElementOperator.Instance;
        public static IPredicateProviderHandlerSuites PredicateProviderSuites => L003.PredicateProviderHandlerSuites.Instance;
        public static IPredicateProviderHandlerSuiteSets PredicateProviderSuiteSets => L003.PredicateProviderHandlerSuiteSets.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
        public static IStringSearchDescriptorHandlers StringSearchDescriptorHandlers => L003.StringSearchDescriptorHandlers.Instance;
        public static IStringSearchDescriptorOperator StringSearchDescriptorOperator => L003.StringSearchDescriptorOperator.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
        public static L0001.ITypeOperator TypeOperator => L0001.TypeOperator.Instance;
        public static ITypeSpecifiers TypeSpecifiers => L003.TypeSpecifiers.Instance;
    }
}