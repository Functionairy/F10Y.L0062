using System;


namespace F10Y.L0062.L002
{
    public static class Instances
    {
        public static L0001.IAnyOrNoneOperator AnyOrNoneOperator => L0001.AnyOrNoneOperator.Instance;
        public static L0001.IArrayOperator ArrayOperator => L0001.ArrayOperator.Instance;
        public static L0001.IContainmentOperator ContainmentOperator => L0001.ContainmentOperator.Instance;
        public static L0001.IContiguityOperator ContiguityOperator => L0001.ContiguityOperator.Instance;
        public static IDescriptorHandlers DescriptorHandlers => L002.DescriptorHandlers.Instance;
        public static IDescriptorOperator DescriptorOperator => L002.DescriptorOperator.Instance;
        public static IDescriptorTextOperationHandlerSuites DescriptorTextOperationHandlerSuites => L002.DescriptorTextOperationHandlerSuites.Instance;
        public static IDescriptorTextOperationHandlerSuiteSets DescriptorTextOperationHandlerSuiteSets => L002.DescriptorTextOperationHandlerSuiteSets.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static IEqualityOperationDescriptorOperator EqualityOperationDescriptorOperator => L002.EqualityOperationDescriptorOperator.Instance;
        public static IEqualityOperationDescriptors EqualityOperationDescriptors => L002.EqualityOperationDescriptors.Instance;
        public static IEqualityOperationDescriptorSets EqualityOperationDescriptorSets => L002.EqualityOperationDescriptorSets.Instance;
        public static IExceptionMessageOperator ExceptionMessageOperator => L002.ExceptionMessageOperator.Instance;
        public static IExceptionMessages ExceptionMessages => L002.ExceptionMessages.Instance;
        public static IExceptionOperator ExceptionOperator => L002.ExceptionOperator.Instance;
        public static IGuidOperator GuidOperator => L002.GuidOperator.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
        public static IHandlerSuites HandlerSuites => L002.HandlerSuites.Instance;
        public static IHandlerSuiteSets HandlerSuiteSets => L002.HandlerSuiteSets.Instance;
        public static IHandlerSuiteOperator HandlerSuiteOperator => L002.HandlerSuiteOperator.Instance;
        public static L0001.IInclusivenessOperator InclusivenessOperator => L0001.InclusivenessOperator.Instance;
        public static L0060.IJsonElementOperator JsonElementOperator => L0060.JsonElementOperator.Instance;
        public static L001.IJsonOperator JsonOperator => L001.JsonOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0001.IOrderDependenceOperator OrderDependenceOperator => L0001.OrderDependenceOperator.Instance;
        public static IPredicateProviderSuites PredicateProviderSuites => L002.PredicateProviderSuites.Instance;
        public static IPredicateProviderSuiteSets PredicateProviderSuiteSets => L002.PredicateProviderSuiteSets.Instance;
        public static L0001.L002.IResultOperator ResultOperator => L0001.L002.ResultOperator.Instance;
        public static ISetEqualityOperationDescriptorOperator SetEqualityOperationDescriptorOperator => L002.SetEqualityOperationDescriptorOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
        public static L0001.ITexts Texts => L0001.Texts.Instance;
        public static L0001.ITypeOperator TypeOperator => L0001.TypeOperator.Instance;
        public static L0000.ITypeNameOperator TypeNameOperator => L0000.TypeNameOperator.Instance;
        public static ITypeSpecifiers TypeSpecifiers => L002.TypeSpecifiers.Instance;
    }
}