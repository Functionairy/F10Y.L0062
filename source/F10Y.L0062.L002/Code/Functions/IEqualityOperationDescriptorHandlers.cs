using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorHandlers
    {
        Func<int, int, bool> Get_PredicateFor_Integer(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            return Instances.IntegerOperator.Are_Equal;
        }

        Func<int, int, bool> Get_PredicateFor_Integer(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            Func<int, int, bool> output = equalityOperationDescriptor.Not
                ? Instances.IntegerOperator.Are_Equal_Not
                : Instances.IntegerOperator.Are_Equal
                ;

            return output;
        }

        Func<string, string, bool> Get_PredicateFor_String(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            return Instances.StringOperator.Are_Equal;
        }

        Func<string, string, bool> Get_PredicateFor_String(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            Func<string, string, bool> output = equalityOperationDescriptor.Not
                ? Instances.StringOperator.Are_Equal_Not
                : Instances.StringOperator.Are_Equal
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            var output = Instances.EnumerableOperator.From("= (simple equals)")
                ;

            return output;
        }

        IEnumerable<string> To_Text(EqualityOperationDescriptor_Simple equalityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(equalityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(equalityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            var output = Instances.EnumerableOperator.From("= (simple equals)")
                .Append($"{equalityOperationDescriptor.Not}: not")
                ;

            return output;
        }

        IEnumerable<string> To_Text(EqualityOperationDescriptor_Simple_WithNot equalityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(equalityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(equalityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
