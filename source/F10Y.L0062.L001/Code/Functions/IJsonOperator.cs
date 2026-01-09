using System;
using System.Text.Json;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062.L001
{
    /// <summary>
    /// JSON operations for the <see cref="JsonSerializationObject"/> type.
    /// </summary>
    [FunctionsMarker]
    public partial interface IJsonOperator :
        L0060.IJsonOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="L0060.IJsonOperator"/>
        [Ignore]
        L0060.IJsonOperator _L0060 => L0060.JsonOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        T From_JsonSerializationObject<T>(
            JsonSerializationObject jsonSerializationObject,
            Func<JsonElement, T> jsonElement_Deserializer)
        {
            var output = jsonElement_Deserializer(jsonSerializationObject.Value);
            return output;
        }

        T From_JsonSerializationObject<T>(JsonSerializationObject jsonSerializationObject)
        {
            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                Instances.JsonElementOperator.Deserialize<T>);

            return output;
        }

        JsonSerializationObject Get_JsonSerializationObject_ForNull()
        {
            var output = JsonSerializationObject.For_Null;
            return output;
        }

        JsonSerializationObject To_JsonSerializationObject<T>(
            T value,
            Func<T, JsonElement> jsonElement_Serializer,
            string typeName)
        {
            var value_IsNull = Instances.NullOperator.Is_Null(value);
            if (value_IsNull)
            {
                return this.Get_JsonSerializationObject_ForNull();
            }

            var jsonElement = jsonElement_Serializer(value);

            var output = new JsonSerializationObject
            {
                TypeName = typeName,
                Value = jsonElement,
            };

            return output;
        }

        JsonSerializationObject To_JsonSerializationObject<T>(
            T value,
            Func<T, JsonElement> jsonElement_Serializer)
        {
            // Use the implementation type.
            var typeName = Instances.TypeOperator.Get_TypeName_OfImplementationType(value);

            var output = this.To_JsonSerializationObject(
                value,
                jsonElement_Serializer,
                typeName);

            return output;
        }

        JsonSerializationObject To_JsonSerializationObject<T>(
            T value)
        {
            var output = this.To_JsonSerializationObject(
                value,
                Instances.JsonElementOperator.Serialize);

            return output;
        }
    }
}
