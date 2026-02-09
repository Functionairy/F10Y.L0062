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
            Equality_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
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

        #region String Search Descriptors

        StringSearchDescriptorHandlerSuite For_StringSearchDescriptor_EqualityOperationDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_EqualityOperationDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<StringSearchDescriptor_EqualityOperationDescriptor, Serialization_StringSearchDescriptor_EqualityOperationDescriptor>(
                Instances.StringSearchDescriptorHandlers.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<StringSearchDescriptor_EqualityOperationDescriptor, Serialization_StringSearchDescriptor_EqualityOperationDescriptor>(
                    Instances.StringSearchDescriptorHandlers.To_SerializationType),
                Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
            Get_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.Get_PredicateFor,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor)
        };

        StringSearchDescriptorHandlerSuite For_StringSearchDescriptor_Equals_Simple => new()
        {
            Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_Equals_Simple>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<StringSearchDescriptor_Equals_Simple>,
            To_JsonElement = Instances.JsonElementOperator.Serialize,
            Get_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.StringSearchDescriptorHandlers.Get_PredicateFor,
                Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple)
        };

        #endregion
    }
}
