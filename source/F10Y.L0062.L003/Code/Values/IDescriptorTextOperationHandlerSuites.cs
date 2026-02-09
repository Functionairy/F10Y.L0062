using System;

using F10Y.T0003;


namespace F10Y.L0062.L003
{
    [ValuesMarker]
    public partial interface IDescriptorTextOperationHandlerSuites
    {
        #region Descriptor Search Descriptors

        //public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IDescriptorSearchDescriptor> For_DescriptorSearchDescriptor_Name_Simple => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<DescriptorSearchDescriptor_Name_Simple>(),
        //    To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.DescriptorSearchDescriptorOperator.To_Text,
        //        Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
        //    To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.DescriptorSearchDescriptorOperator.To_Text_ContentOnly,
        //        Instances.TypeSpecifiers.For_DescriptorSearchDescriptor_Name_Simple),
        //    From_JsonElement = Instances.JsonElementOperator.Deserialize<DescriptorSearchDescriptor_Name_Simple>,
        //    To_JsonElement = Instances.JsonElementOperator.Serialize
        //};

        #endregion

        #region String Search Descriptors

        //public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor> For_StringSearchDescriptor_EqualityOperationDescriptor => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_EqualityOperationDescriptor>(),
        //    To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.To_Text,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
        //    To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.To_Text_ContentOnly,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor),
        //    From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<StringSearchDescriptor_EqualityOperationDescriptor, Serialization_StringSearchDescriptor_EqualityOperationDescriptor>(
        //        Instances.StringSearchDescriptorOperator.From_SerializationType),
        //    To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.JsonElementOperator.Get_Serialize<StringSearchDescriptor_EqualityOperationDescriptor, Serialization_StringSearchDescriptor_EqualityOperationDescriptor>(
        //            Instances.StringSearchDescriptorOperator.To_SerializationType),
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_EqualityOperationDescriptor)
        //};

        //public For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IStringSearchDescriptor> For_StringSearchDescriptor_Equals_Simple => new()
        //{
        //    Type = Instances.TypeOperator.Get_Type<StringSearchDescriptor_Equals_Simple>(),
        //    To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.To_Text,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple),
        //    To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
        //        Instances.StringSearchDescriptorOperator.To_Text_ContentOnly,
        //        Instances.TypeSpecifiers.For_StringSearchDescriptor_Equals_Simple),
        //    From_JsonElement = Instances.JsonElementOperator.Deserialize<StringSearchDescriptor_Equals_Simple>,
        //    To_JsonElement = Instances.JsonElementOperator.Serialize
        //};

        #endregion
    }
}
