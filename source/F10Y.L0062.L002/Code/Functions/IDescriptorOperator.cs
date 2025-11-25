using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator :
        T000.IDescriptorOperator,
        Bases.IDescriptorTextOperator<IDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IDescriptorOperator _T000 => T000.DescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, DescriptorTextOperationHandlerSuite<IDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_Descriptors_ByType;

        Dictionary<string, DescriptorTextOperationHandlerSuite<IDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_Descriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(IDescriptor descriptor)
        {
            var ID = Instances.GuidOperator.To_String_ForDescriptor(descriptor.Identity);

            var output = Instances.EnumerableOperator.From(
                $"{descriptor.Name} ({ID})",
                descriptor.Description
            );

            return output;
        }

        public IEnumerable<string> To_Text(IDescriptor descriptor)
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
