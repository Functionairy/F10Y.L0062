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
            Equality_Predicate = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
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
            To_JsonElement = Instances.JsonElementOperator.Serialize,
            Get_Descriptor = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.DescriptorHandlers.Get_Descriptor,
                Instances.TypeSpecifiers.For_Descriptor)
        };

        #endregion

        #region Equality Operation Descriptor

        EqualityOperationDescriptorHandlerSuite For_EqualityOperationDescriptor_Simple => new()
        {
            Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<EqualityOperationDescriptor_Simple>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        EqualityOperationDescriptorHandlerSuite For_EqualityOperationDescriptor_Simple_WithNot => new()
        {
            Type = Instances.TypeOperator.Get_Type<EqualityOperationDescriptor_Simple_WithNot>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.EqualityOperationDescriptorHandlers.To_Text,
               Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
               Instances.EqualityOperationDescriptorHandlers.To_Text_ContentOnly,
               Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot),
            From_JsonElement = Instances.JsonElementOperator.Deserialize<EqualityOperationDescriptor_Simple_WithNot>,
            To_JsonElement = Instances.JsonElementOperator.Serialize
        };

        #endregion

        #region Equality Operation Descriptor - Integer

        EqualityOperationDescriptorHandlerSuite<int> For_EqualityOperationDescriptor_Simple_OfInteger => Instances.EqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_EqualityOperationDescriptor_Simple,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.Get_PredicateFor_Integer,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple));

        EqualityOperationDescriptorHandlerSuite<int> For_EqualityOperationDescriptor_Simple_WithNot_OfInteger => Instances.EqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_EqualityOperationDescriptor_Simple_WithNot,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.Get_PredicateFor_Integer,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot));

        #endregion

        #region Equality Operation Descriptor - String

        EqualityOperationDescriptorHandlerSuite<string> For_EqualityOperationDescriptor_Simple_OfString => Instances.EqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_EqualityOperationDescriptor_Simple,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.Get_PredicateFor_String,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple));

        EqualityOperationDescriptorHandlerSuite<string> For_EqualityOperationDescriptor_Simple_WithNot_OfString => Instances.EqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_EqualityOperationDescriptor_Simple_WithNot,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.EqualityOperationDescriptorHandlers.Get_PredicateFor_String,
                Instances.TypeSpecifiers.For_EqualityOperationDescriptor_Simple_WithNot));

        #endregion

        #region Hash Code Operation Descriptor - String

        HashCodeOperationDescriptorHandlerSuite<string> For_HashCodeOperationDescriptor_Simple => new()
        {
            Type = Instances.TypeOperator.Get_Type<HashCodeOperationDescriptor_Simple>(),
            Get_HashCodeOperation = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.HashCodeOperationDescriptorHandlers.Get_HashCodeFor_String,
                Instances.TypeSpecifiers.For_HashCodeOperationDescriptor_Simple)
        };

        #endregion

        #region Set Equality Operation Descriptor

        SetEqualityOperationDescriptorHandlerSuite For_SetEqualityOperationDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text_ContentOnly_ForString,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor>(
                Instances.SetEqualityOperationDescriptorHandlers.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor>(
                    Instances.SetEqualityOperationDescriptorHandlers.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor
            )
        };

        SetEqualityOperationDescriptorHandlerSuite For_SetEqualityOperationDescriptor_Containment => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Containment>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor_Containment, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment>(
                Instances.SetEqualityOperationDescriptorHandlers.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor_Containment, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment>(
                    Instances.SetEqualityOperationDescriptorHandlers.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment
            )
        };

        SetEqualityOperationDescriptorHandlerSuite For_SetEqualityOperationDescriptor_Intersection => new()
        {
            Type = Instances.TypeOperator.Get_Type<SetEqualityOperationDescriptor_Intersection>(),
            To_Text = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection),
            To_Text_ContentOnly = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.To_Text_ContentOnly,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection),
            From_JsonElement = Instances.JsonElementOperator.Get_Deserialize<SetEqualityOperationDescriptor_Intersection, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection>(
                Instances.SetEqualityOperationDescriptorHandlers.From_SerializationType),
            To_JsonElement = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.JsonElementOperator.Get_Serialize<SetEqualityOperationDescriptor_Intersection, For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection>(
                    Instances.SetEqualityOperationDescriptorHandlers.To_SerializationType),
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection
            )
        };

        #endregion

        #region Set Equality Operation Descriptor - String

        SetEqualityOperationDescriptorHandlerSuite<string[]> For_SetEqualityOperationDescriptor_OfString => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_String,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor));

        SetEqualityOperationDescriptorHandlerSuite<string[]> For_SetEqualityOperationDescriptor_Containment_OfString => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor_Containment,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_String,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment));

        SetEqualityOperationDescriptorHandlerSuite<string[]> For_SetEqualityOperationDescriptor_Intersection_OfString => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor_Intersection,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_String,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection));

        #endregion

        #region Set Equality Operation Descriptor - Integer

        SetEqualityOperationDescriptorHandlerSuite<int[]> For_SetEqualityOperationDescriptor_OfInteger => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_Integer,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor));

        SetEqualityOperationDescriptorHandlerSuite<int[]> For_SetEqualityOperationDescriptor_Containment_OfInteger => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor_Containment,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_Integer,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Containment));

        SetEqualityOperationDescriptorHandlerSuite<int[]> For_SetEqualityOperationDescriptor_Intersection_OfInteger => Instances.SetEqualityOperationDescriptorHandlerSuiteOperator.From(
            this.For_SetEqualityOperationDescriptor_Intersection,
            Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.SetEqualityOperationDescriptorHandlers.Get_PredicateFor_Integer,
                Instances.TypeSpecifiers.For_SetEqualityOperationDescriptor_Intersection));

        #endregion
    }
}
