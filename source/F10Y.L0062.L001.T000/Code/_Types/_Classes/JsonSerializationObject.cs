using System;
using System.Text.Json;

using F10Y.T0004;


namespace F10Y.L0062.L001.T000
{
    [DataTypeMarker]
    public class JsonSerializationObject :
        IWith_Value_AsJsonElement,
        IWith_TypeName
    {
        #region Static

        /// <summary>
        /// The common value to use for null values (is null).
        /// </summary>
        /// <remarks>
        /// Provides a value to all client code for use in the case where an JSON serialization object needs to serialize a null value.
        /// </remarks>
        public static JsonSerializationObject For_Null => null;

        #endregion


        /// <summary>
        /// The name of type (in-memory) to be serialized.
        /// </summary>
        /// <remarks>
        /// No assumption is made about the form of the type name.
        /// This is left up to client code that actually does the serialization.
        /// </remarks>
        public string TypeName { get; set; }

        /// <summary>
        /// The raw JSON of the value to be serialized.
        /// </summary>
        public JsonElement Value { get; set; }
    }
}
