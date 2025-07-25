using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IStringSearchDescriptorOperator :
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IStringSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IStringSearchDescriptor, string>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IStringSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_StringSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IStringSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_StringSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IStringSearchDescriptor, string>> For_Bases_IPredicateOperator.IPredicateOperator<IStringSearchDescriptor, string>.PredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_StringSearchDescriptors_ByType;


        public StringSearchDescriptor_EqualityOperationDescriptor From_SerializationType(Serialization_StringSearchDescriptor_EqualityOperationDescriptor instanceSetDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.EqualityOperationDescriptor);

            var output = new StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = instanceSetDescriptor.Value,
            };

            return output;
        }

        public Serialization_StringSearchDescriptor_EqualityOperationDescriptor To_SerializationType(StringSearchDescriptor_EqualityOperationDescriptor instanceSetDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.EqualityOperationDescriptor);

            var output = new Serialization_StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = instanceSetDescriptor.Value,
            };

            return output;
        }

        public StringSearchDescriptor_Equals_Simple From_ToEqualsSimple(string value)
        {
            var output = new StringSearchDescriptor_Equals_Simple
            {
                Value = value
            };

            return output;
        }

        public StringSearchDescriptor_EqualityOperationDescriptor From(
            string value,
            For_EqualityOperationDescriptor.IEqualityOperationDescriptor equalityOperationDescriptor)
        {
            var output = new StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = value
            };

            return output;
        }

        public bool Evaluate(
            StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor,
            string value)
        {
            var equalityOperation_Has_Predicate = Instances.EqualityOperationDescriptorOperator.Has_Predicate_Synchronous(stringSearchDescriptor.EqualityOperationDescriptor);
            if (!equalityOperation_Has_Predicate.Success)
            {
                throw new Exception("No predicate found for equality operation descriptor.");
            }

            var output = equalityOperation_Has_Predicate.Value(
                stringSearchDescriptor.Value,
                value);

            return output;
        }

        public Func<string, bool> Get_PredicateFor(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
            => value => this.Evaluate(
                stringSearchDescriptor,
                value);

        public Func<string, bool> Get_PredicateFor(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
            => value => stringSearchDescriptor.Value == value;

        public IEnumerable<string> To_Text_ContentOnly(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
        {
            var equalityOperation_Lines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(stringSearchDescriptor.EqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"{stringSearchDescriptor.Value}: value")
                .Append_Many(Instances.EnumerableOperator.From("Equality Operation:")
                    .Append_Many(equalityOperation_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(stringSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(stringSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"String Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{stringSearchDescriptor.Value}: value")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(stringSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(stringSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"String Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
