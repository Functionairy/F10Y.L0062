using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IJsonElementSerializationHandlerSuiteOperator<THandled, THandlerSuite> :
        N003.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.IJsonElementSerializationHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : IJsonElementSerializationHandlerSuite<THandled>
    {
        THandled[] From_JsonSerializationObjects(IEnumerable<JsonSerializationObject> jsonSerializationObjects)
            => this.From_JsonSerializationObjects(
                jsonSerializationObjects,
                this.HandlerSuites_ByHandledImplementationTypeName);

        THandled[] From_JsonSerializationObjects_NullIfNull(IEnumerable<JsonSerializationObject> jsonSerializationObjects)
        {
            var is_Null = Instances.NullOperator.Is_Null(jsonSerializationObjects);

            var output = is_Null
                ? null
                : this.From_JsonSerializationObjects(jsonSerializationObjects)
                ;

            return output;
        }

        Task<THandled[]> Deserialize_Many_FromJsonFile(string jsonFilePath)
        {
            return this.Deserialize_Many_FromJsonFile(
                jsonFilePath,
                this.HandlerSuites_ByHandledImplementationTypeName);
        }

        Task<THandled> Deserialize_FromJsonFile(string jsonFilePath)
        {
            var output = this.Deserialize_FromJsonFile(
                jsonFilePath,
                this.HandlerSuites_ByHandledImplementationTypeName);

            return output;
        }

        THandled Deserialize_FromJsonText(string jsonText)
        {
            var output = this.Deserialize_FromJsonText(
                jsonText,
                this.HandlerSuites_ByHandledImplementationTypeName);

            return output;
        }

        THandled From_JsonSerializationObject(JsonSerializationObject jsonSerializationObject)
        {
            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                this.HandlerSuites_ByHandledImplementationTypeName);

            return output;
        }

        JsonSerializationObject[] To_JsonSerializationObjects(params THandled[] descriptors)
            => this.To_JsonSerializationObjects(
                descriptors,
                this.HandlerSuites_ByHandledImplementationType);

        JsonSerializationObject[] To_JsonSerializationObjects_NullIfNull(params THandled[] descriptors)
            => Instances.NullOperator.If_Null_Else(
                descriptors,
                this.To_JsonSerializationObjects);

        Task Serialize_ToJsonFile(
            string jsonFilePath,
            IEnumerable<THandled> descriptors)
        {
            return this.Serialize_ToJsonFile(
                jsonFilePath,
                descriptors,
                this.HandlerSuites_ByHandledImplementationType);
        }

        Task Serialize_ToJsonFile(
            string jsonFilePath,
            params THandled[] descriptors)
        {
            return this.Serialize_ToJsonFile(
                jsonFilePath,
                descriptors,
                this.HandlerSuites_ByHandledImplementationType);
        }

        Task Serialize_ToJsonFile(
            string jsonFilePath,
            THandled descriptor)
            => this.Serialize_ToJsonFile(
                jsonFilePath,
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        string Serialize_ToJsonText(
            THandled descriptor)
            => this.Serialize_ToJsonText(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        JsonSerializationObject To_JsonSerializationObject(THandled descriptor)
        {
            var output = this.To_JsonSerializationObject(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

            return output;
        }
    }
}
