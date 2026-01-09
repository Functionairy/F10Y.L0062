using System;

using F10Y.T0003;


namespace F10Y.L0062.L002
{
    [ValuesMarker]
    public partial interface IHandlerSuites
    {
        #region Descriptors

        DescriptorHandlerSuite For_Descriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<Descriptor>(),
            EqualityPredicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.Are_Equal,
                Instances.TypeSpecifiers.For_Descriptor,
                Instances.TypeSpecifiers.For_IDescriptor),
            Get_HashCode = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.Get_HashCode,
                Instances.TypeSpecifiers.For_Descriptor),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_Descriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_Descriptor),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<Descriptor>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion
    }
}
