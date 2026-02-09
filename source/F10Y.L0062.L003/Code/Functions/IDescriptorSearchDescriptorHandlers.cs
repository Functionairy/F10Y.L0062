using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IDescriptorSearchDescriptorHandlers
    {
        bool Are_Equal(
           DescriptorSearchDescriptor_Name_Simple a,
           IDescriptorSearchDescriptor b)
        {
            var output = Instances.TypeOperator.If_TypeIs_ElseFalse(
                a,
                b,
                this.Are_Equal);

            return output;
        }

        bool Are_Equal(
            DescriptorSearchDescriptor_Name_Simple a,
            DescriptorSearchDescriptor_Name_Simple b)
        {
            var output = Instances.StringOperator.Are_Equal(
                a.Name,
                b.Name);

            return output;
        }

        int Get_HashCode(DescriptorSearchDescriptor_Name_Simple searchDescriptor)
            => Instances.HashCodeOperator.Get_HashCode(searchDescriptor.Name);

        bool Evaluate(
            DescriptorSearchDescriptor_Name_Simple searchDescriptor,
            IDescriptor descriptor)
        {
            var descriptor_Name = Instances.DescriptorOperator.Get_Name(descriptor);

            var output = Instances.StringOperator.Are_Equal(
                searchDescriptor.Name,
                descriptor_Name);

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(DescriptorSearchDescriptor_Name_Simple descriptorSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{descriptorSearchDescriptor.Name}: name")
                ;

            return output;
        }

        IEnumerable<string> To_Text(DescriptorSearchDescriptor_Name_Simple descriptorSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(descriptorSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(descriptorSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Descriptor Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
