using System;

using F10Y.T0003;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Descriptors

        public DescriptorTextOperationHandlerSuite<IDescriptor> For_Descriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<Descriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_Descriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_Descriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<Descriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Equality Operation Descriptors

        public DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor> For_EqualityOperationDescriptor_Simple => new()
        {
            Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_OfString),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_OfString),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<EqualityOperationDescriptor_Simple>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        public DescriptorTextOperationHandlerSuite<IEqualityOperationDescriptor> For_EqualityOperationDescriptor_Simple_WithNot => new()
        {
            Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple_WithNot>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.EqualityOperationDescriptorOperator.To_Text,
               Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot_OfString),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly,
               Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot_OfString),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<EqualityOperationDescriptor_Simple_WithNot>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Set Equality Operation Descriptors

        public DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor> For_SetEqualityOperationDescriptor_OfString => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_OfString),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_OfString),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor>(
                Instances.SetEqualityOperationDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor>(
                    Instances.SetEqualityOperationDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_OfString
            )
        };

        public DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor> For_SetEqualityOperationDescriptor_Containment_OfString => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Containment>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment_OfString),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment_OfString),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor_Containment, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment>(
                Instances.SetEqualityOperationDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor_Containment, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment>(
                    Instances.SetEqualityOperationDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment_OfString
            )
        };

        public DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor> For_SetEqualityOperationDescriptor_Intersection_OfString => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Intersection>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection_OfString),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorOperator.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection_OfString),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor_Intersection, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection>(
                Instances.SetEqualityOperationDescriptorOperator.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor_Intersection, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection>(
                    Instances.SetEqualityOperationDescriptorOperator.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection_OfString
            )
        };

        #endregion
    }
}
