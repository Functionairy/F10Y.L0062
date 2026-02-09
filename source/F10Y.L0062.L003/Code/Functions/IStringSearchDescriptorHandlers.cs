using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IStringSearchDescriptorHandlers
    {
        StringSearchDescriptor_EqualityOperationDescriptor From_SerializationType(Serialization_StringSearchDescriptor_EqualityOperationDescriptor instanceSetDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.EqualityOperationDescriptor);

            var output = new StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = instanceSetDescriptor.Value,
            };

            return output;
        }

        Serialization_StringSearchDescriptor_EqualityOperationDescriptor To_SerializationType(StringSearchDescriptor_EqualityOperationDescriptor instanceSetDescriptor)
        {
            var equalityOperationDescriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.EqualityOperationDescriptor);

            var output = new Serialization_StringSearchDescriptor_EqualityOperationDescriptor
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Value = instanceSetDescriptor.Value,
            };

            return output;
        }

        bool Evaluate(
            StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor,
            string value)
        {
            var equalityOperation_Has_Predicate = Instances.EqualityOperationDescriptorOperator.For_String.Has_Predicate(stringSearchDescriptor.EqualityOperationDescriptor);
            if (!equalityOperation_Has_Predicate.Success)
            {
                throw new Exception("No predicate found for equality operation descriptor.");
            }

            var output = equalityOperation_Has_Predicate.Value(
                stringSearchDescriptor.Value,
                value);

            return output;
        }

        Func<string, bool> Get_PredicateFor(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
            => value => this.Evaluate(
                stringSearchDescriptor,
                value);

        Func<string, bool> Get_PredicateFor(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
            => value => stringSearchDescriptor.Value == value;

        IEnumerable<string> To_Text_ContentOnly(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
        {
            var equalityOperation_Lines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(stringSearchDescriptor.EqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"{stringSearchDescriptor.Value}: value")
                .Append_Many(Instances.EnumerableOperator.From("Equality Operation:")
                    .Append_Many(equalityOperation_Lines.Entab())
                )
                ;

            return output;
        }

        IEnumerable<string> To_Text(StringSearchDescriptor_EqualityOperationDescriptor stringSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(stringSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(stringSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"String Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{stringSearchDescriptor.Value}: value")
                ;

            return output;
        }

        IEnumerable<string> To_Text(StringSearchDescriptor_Equals_Simple stringSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(stringSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(stringSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"String Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
