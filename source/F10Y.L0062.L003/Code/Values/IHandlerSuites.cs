using System;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IHandlerSuites
    {
        #region Descriptor Search Descriptors

        DescriptorSearchDescriptorHandlerSuite For_DescriptorSearchDescriptor_Name_Simple => new()
        {
            Type = Instances.TypeOperator.Get_Type<DescriptorSearchDescriptor_Name_Simple>(),
            EqualityPredicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorSearchDescriptorHandlers.Are_Equal,
                Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple,
                Instances.TypeSpecifiers.For_IDescriptorSearchDescriptor),
            Get_HashCode = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorSearchDescriptorHandlers.Get_HashCode,
                Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorSearchDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorSearchDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<DescriptorSearchDescriptor_Name_Simple>,
            To_JsonElement = Instances.JsonElementOperator.Serialize,
            Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorSearchDescriptorHandlers.Evaluate,
                Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple,
                Instances.TypeSpecifiers.For_IDescriptor)
        };

        #endregion
    }
}
