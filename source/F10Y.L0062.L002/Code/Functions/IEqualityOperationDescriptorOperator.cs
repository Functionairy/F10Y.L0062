using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorOperator :
        T000.IEqualityOperationDescriptorOperator,
        Bases.IDescriptorTextOperator<IEqualityOperationDescriptor>,
        Bases.IBinaryPredicateOperator<IEqualityOperationDescriptor, string>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IEqualityOperationDescriptorOperator _T000 => T000.EqualityOperationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IEqualityOperationDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_EqualityOperationDescriptors_ByType;

        Dictionary<string, DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IEqualityOperationDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_EqualityOperationDescriptors_ByTypeName;

        Dictionary<Type, BinaryPredicateProviderSuite<IEqualityOperationDescriptor, string>> Bases.IBinaryPredicateOperator<IEqualityOperationDescriptor, string>.BinaryPredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_EqualityOperationDescriptors_OfString_ByType;


        public Func<string, string, bool> Get_PredicateFor(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            return Instances.StringOperator.Are_Equal;
        }

        public Func<string, string, bool> Get_PredicateFor(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            Func<string, string, bool> output = equalityOperationDescriptor.Not
                ? Instances.StringOperator.Are_Equal_Not
                : Instances.StringOperator.Are_Equal
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            var output = Instances.EnumerableOperator.From("= (simple equals)")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(equalityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(equalityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            var output = Instances.EnumerableOperator.From("= (simple equals)")
                .Append($"{equalityOperationDescriptor.Not}: not")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(equalityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(equalityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
