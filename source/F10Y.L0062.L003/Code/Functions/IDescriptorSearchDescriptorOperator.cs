using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L003
{
    [FunctionsMarker]
    public partial interface IDescriptorSearchDescriptorOperator :
        T000.IDescriptorSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDescriptorSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IDescriptorSearchDescriptor, IDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.IDescriptorSearchDescriptorOperator _T000 => T000.DescriptorSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDescriptorSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DescriptorSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IDescriptorSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_DescriptorSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IDescriptorSearchDescriptor, IDescriptor>> For_Bases_IPredicateOperator.IPredicateOperator<IDescriptorSearchDescriptor, IDescriptor>.PredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_DescriptorSearchDescriptors_ByType;


        public Func<IDescriptor, bool> Get_PredicateFor(DescriptorSearchDescriptor_Name_Simple descriptorSearchDescriptor)
            => value => Instances.StringOperator.Are_Equal(
                descriptorSearchDescriptor.Name,
                value.Name);

        public IEnumerable<string> To_Text_ContentOnly(DescriptorSearchDescriptor_Name_Simple descriptorSearchDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{descriptorSearchDescriptor.Name}: name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(DescriptorSearchDescriptor_Name_Simple descriptorSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(descriptorSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(descriptorSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Descriptor Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
