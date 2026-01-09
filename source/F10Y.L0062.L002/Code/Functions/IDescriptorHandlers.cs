using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IDescriptorHandlers
    {
        bool Are_Equal(
            Descriptor a,
            IDescriptor b)
            => Instances.TypeOperator.If_TypeIs_ElseFalse(
                a,
                b,
                this.Are_Equal);

        bool Are_Equal(
            Descriptor a,
            Descriptor b)
        {
            var output = true
                && Instances.GuidOperator.Are_Equal(
                    a.Identity,
                    b.Identity)
                && Instances.StringOperator.Are_Equal(
                    a.Name,
                    b.Name)
                && Instances.StringOperator.Are_Equal(
                    a.Description,
                    b.Description)
                ;

            return output;
        }

        int Get_HashCode(Descriptor descriptor)
            => Instances.HashCodeOperator.Get_HashCode(
                descriptor.Identity,
                descriptor.Name,
                descriptor.Description);

        IEnumerable<string> To_Text_ContentOnly(IDescriptor descriptor)
        {
            var ID = Instances.GuidOperator.To_String_ForDescriptor(descriptor.Identity);

            var output = Instances.EnumerableOperator.From(
                $"{descriptor.Name} ({ID})",
                descriptor.Description
            );

            return output;
        }

        IEnumerable<string> To_Text(IDescriptor descriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(descriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(descriptor);

            var output = Instances.EnumerableOperator.From($"Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
