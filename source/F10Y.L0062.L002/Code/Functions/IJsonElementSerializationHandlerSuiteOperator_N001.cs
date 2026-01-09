using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    [FunctionsMarker]
    public partial interface IJsonElementSerializationHandlerSuiteOperator<THandled, THandlerSuite> :
        L002.IHandlerSuiteOperator
        where THandlerSuite : IJsonElementSerializationHandlerSuite<THandled>
    {
        THandled From_JsonSerializationObject(
            JsonSerializationObject jsonSerializationObject,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var isNull = Instances.NullOperator.Is_Null(jsonSerializationObject);
            if (isNull)
            {
                return default;
            }

            var handlerSuite = this.Verify_CanHandle(
                jsonSerializationObject.TypeName,
                handlerSuites_ByTypeName);

            var descriptor = Instances.JsonOperator.From_JsonSerializationObject(
                jsonSerializationObject,
                handlerSuite.From_JsonElement);

            return descriptor;
        }

        IEnumerable<THandled> Enumerate_FromJsonSerializationObjects(
            IEnumerable<JsonSerializationObject> jsonSerializationObjects,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var output = jsonSerializationObjects
                .Select(jsonSerializationObject => this.From_JsonSerializationObject(
                    jsonSerializationObject,
                    handlerSuites_ByTypeName)
                )
                ;

            return output;
        }

        THandled[] From_JsonSerializationObjects(
            IEnumerable<JsonSerializationObject> jsonSerializationObjects,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var output = this.Enumerate_FromJsonSerializationObjects(
                jsonSerializationObjects,
                handlerSuites_ByTypeName)
                .ToArray();

            return output;
        }

        /// <summary>
        /// Deserialize from a <see cref="JsonSerializationObject"/>-formatted JSON text.
        /// </summary>
        THandled Deserialize_FromJsonText(
            string jsonText,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var jsonSerializationObject = Instances.JsonOperator.Deserialize_FromText<JsonSerializationObject>(jsonText);

            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                handlerSuites_ByTypeName);

            return output;
        }

        /// <summary>
        /// Deserialize from a <see cref="JsonSerializationObject"/>-formatted JSON file.
        /// </summary>
        async Task<THandled> Deserialize_FromJsonFile(
            string jsonText,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var jsonSerializationObject = await Instances.JsonOperator.Deserialize_FromFile<JsonSerializationObject>(jsonText);

            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                handlerSuites_ByTypeName);

            return output;
        }

        async Task<THandled[]> Deserialize_Many_FromJsonFile(
            string jsonFilePath,
            IDictionary<string, THandlerSuite> handlerSuites_ByTypeName)
        {
            var jsonSerializationObjects = await Instances.JsonOperator.Deserialize_FromFile<JsonSerializationObject[]>(jsonFilePath);

            var output = this.From_JsonSerializationObjects(
                jsonSerializationObjects,
                handlerSuites_ByTypeName);

            return output;
        }

        IEnumerable<JsonSerializationObject> Enumerate_JsonSerializationObjects(
            IEnumerable<THandled> descriptors,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var output = descriptors
                .Select(descriptor => this.To_JsonSerializationObject(
                    descriptor,
                    handlerSuites_ByType)
                )
                ;

            return output;
        }

        JsonSerializationObject To_JsonSerializationObject(
            THandled descriptor,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                return Instances.JsonOperator.Get_JsonSerializationObject_ForNull();
            }

            var handlerSuite = this.Verify_CanHandle(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.JsonOperator.To_JsonSerializationObject(
                descriptor,
                handlerSuite.To_JsonElement);

            return output;
        }

        JsonSerializationObject[] To_JsonSerializationObjects(
            THandled[] descriptors,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
            => descriptors
                .Select(descriptor => this.To_JsonSerializationObject(
                    descriptor,
                    handlerSuites_ByType))
                .ToArray();

        async Task Serialize_ToJsonFile(
            string jsonFilePath,
            THandled descriptor,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var jsonSerializationObject = this.To_JsonSerializationObject(
                descriptor,
                handlerSuites_ByType);

            await Instances.JsonOperator.Serialize(
                jsonFilePath,
                jsonSerializationObject);
        }

        async Task Serialize_ToJsonFile(
            string jsonFilePath,
            IEnumerable<THandled> descriptors,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var jsonSerializationObjects = this.Enumerate_JsonSerializationObjects(
                descriptors,
                handlerSuites_ByType);

            await Instances.JsonOperator.Serialize(
                jsonFilePath,
                jsonSerializationObjects);
        }

        string Serialize_ToJsonText(
            THandled descriptor,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var jsonSerializationObject = this.To_JsonSerializationObject(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.JsonOperator.Serialize_ToText(jsonSerializationObject);
            return output;
        }
    }
}
