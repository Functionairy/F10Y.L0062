using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0062.L002.Bases
{
    ///// <summary>
    ///// 
    ///// </summary>
    ///// <remarks>
    ///// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    ///// </remarks>
    //[FunctionsMarker]
    //public partial interface IDescriptorTextOperator<TDescriptor> :
    //    N001.IDescriptorTextOperator<TDescriptor>
    //{
    //    Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> TextHandlerSuites_ByType { get; }

    //    Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> TextHandlerSuites_ByTypeName { get; }


    //    TDescriptor[] From_JsonSerializationObjects(IEnumerable<JsonSerializationObject> jsonSerializationObjects)
    //        => this.From_JsonSerializationObjects(
    //            jsonSerializationObjects,
    //            this.TextHandlerSuites_ByTypeName);

    //    TDescriptor[] From_JsonSerializationObjects_NullIfNull(IEnumerable<JsonSerializationObject> jsonSerializationObjects)
    //    {
    //        var is_Null = Instances.NullOperator.Is_Null(jsonSerializationObjects);

    //        var output = is_Null
    //            ? null
    //            : this.From_JsonSerializationObjects(jsonSerializationObjects)
    //            ;

    //        return output;
    //    }

    //    Task<TDescriptor[]> Deserialize_Many_FromJsonFile(string jsonFilePath)
    //    {
    //        return this.Deserialize_Many_FromJsonFile(
    //            jsonFilePath,
    //            this.TextHandlerSuites_ByTypeName);
    //    }

    //    Task<TDescriptor> Deserialize_FromJsonFile(string jsonFilePath)
    //    {
    //        var output = this.Deserialize_FromJsonFile(
    //            jsonFilePath,
    //            this.TextHandlerSuites_ByTypeName);

    //        return output;
    //    }

    //    TDescriptor Deserialize_FromJsonText(string jsonText)
    //    {
    //        var output = this.Deserialize_FromJsonText(
    //            jsonText,
    //            this.TextHandlerSuites_ByTypeName);

    //        return output;
    //    }

    //    TDescriptor From_JsonSerializationObject(JsonSerializationObject jsonSerializationObject)
    //    {
    //        var output = this.From_JsonSerializationObject(
    //            jsonSerializationObject,
    //            this.TextHandlerSuites_ByTypeName);

    //        return output;
    //    }

    //    JsonSerializationObject[] To_JsonSerializationObjects(params TDescriptor[] descriptors)
    //        => this.To_JsonSerializationObjects(
    //            descriptors,
    //            this.TextHandlerSuites_ByType);

    //    JsonSerializationObject[] To_JsonSerializationObjects_NullIfNull(params TDescriptor[] descriptors)
    //        => Instances.NullOperator.If_Null_Else(
    //            descriptors,
    //            this.To_JsonSerializationObjects);

    //    Task Serialize_ToJsonFile(
    //        string jsonFilePath,
    //        IEnumerable<TDescriptor> descriptors)
    //    {
    //        return this.Serialize_ToJsonFile(
    //            jsonFilePath,
    //            descriptors,
    //            this.TextHandlerSuites_ByType);
    //    }

    //    Task Serialize_ToJsonFile(
    //        string jsonFilePath,
    //        TDescriptor descriptor)
    //        => this.Serialize_ToJsonFile(
    //            jsonFilePath,
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //    string Serialize_ToJsonText(
    //        TDescriptor descriptor)
    //        => this.Serialize_ToJsonText(
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //    JsonSerializationObject To_JsonSerializationObject(TDescriptor descriptor)
    //    {
    //        var output = this.To_JsonSerializationObject(
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //        return output;
    //    }

    //    For_Results.N003.Result<
    //        IEnumerable<string>,
    //        For_Results.N002.IFailed<TDescriptor>>
    //        To_Text_AsResult(
    //        TDescriptor descriptor)
    //    {
    //        var output = this.To_Text_AsResult(
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //        return output;
    //    }

    //    For_Results.N003.Result<
    //        IEnumerable<string>,
    //        For_Results.N002.IFailed<TDescriptor>[]>
    //        To_Text_AsResult(
    //        IEnumerable<TDescriptor> descriptors)
    //    {
    //        var output = this.To_Text_AsResult(
    //            descriptors,
    //            this.TextHandlerSuites_ByType);

    //        return output;
    //    }

    //    IEnumerable<string> To_Text_ContentOnly_Noexceptive(TDescriptor descriptor)
    //    {
    //        var output = this.To_Text_ContentOnly_Noexceptive(
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //        return output;
    //    }

    //    IEnumerable<string> To_Text_Noexceptive(TDescriptor descriptor)
    //    {
    //        var output = this.To_Text_Noexceptive(
    //            descriptor,
    //            this.TextHandlerSuites_ByType);

    //        return output;
    //    }
    //}
}
