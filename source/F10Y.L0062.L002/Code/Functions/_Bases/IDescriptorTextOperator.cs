using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0062.L002.Bases
{
    [FunctionsMarker]
    public partial interface IDescriptorTextOperator<TDescriptor>
    {
        Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> TextHandlerSuites_ByType { get; }

        Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> TextHandlerSuites_ByTypeName { get; }


        public TDescriptor From_JsonSerializationObject(
            JsonSerializationObject jsonSerializationObject,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
        {
            var isNull = Instances.NullOperator.Is_Null(jsonSerializationObject);
            if (isNull)
            {
                return default;
            }

            var handlerSuite = Instances.HandlerSuiteOperator.Verify_CanHandle(
                jsonSerializationObject.TypeName,
                handlerSuites_ByTypeName);

            var descriptor = Instances.JsonOperator.From_JsonSerializationObject(
                jsonSerializationObject,
                handlerSuite.From_JsonElement);

            return descriptor;
        }

        public IEnumerable<TDescriptor> Enumerate_FromJsonSerializationObjects(
            IEnumerable<JsonSerializationObject> jsonSerializationObjects,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
        {
            var output = jsonSerializationObjects
                .Select(jsonSerializationObject => this.From_JsonSerializationObject(
                    jsonSerializationObject,
                    handlerSuites_ByTypeName)
                )
                ;

            return output;
        }

        public TDescriptor[] From_JsonSerializationObjects(
            IEnumerable<JsonSerializationObject> jsonSerializationObjects,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
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
        public TDescriptor Deserialize_FromJsonText(
            string jsonText,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
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
        public async Task<TDescriptor> Deserialize_FromJsonFile(
            string jsonText,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
        {
            var jsonSerializationObject = await Instances.JsonOperator.Deserialize_FromFile<JsonSerializationObject>(jsonText);

            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                handlerSuites_ByTypeName);

            return output;
        }

        public async Task<TDescriptor[]> Deserialize_Many_FromJsonFile(
            string jsonFilePath,
            Dictionary<string, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByTypeName)
        {
            var jsonSerializationObjects = await Instances.JsonOperator.Deserialize_FromFile<JsonSerializationObject[]>(jsonFilePath);

            var output = this.From_JsonSerializationObjects(
                jsonSerializationObjects,
                handlerSuites_ByTypeName);

            return output;
        }

        public Task<TDescriptor[]> Deserialize_Many_FromJsonFile(string jsonFilePath)
        {
            return this.Deserialize_Many_FromJsonFile(
                jsonFilePath,
                this.TextHandlerSuites_ByTypeName);
        }

        public Task<TDescriptor> Deserialize_FromJsonFile(string jsonFilePath)
        {
            var output = this.Deserialize_FromJsonFile(
                jsonFilePath,
                this.TextHandlerSuites_ByTypeName);

            return output;
        }

        public TDescriptor Deserialize_FromJsonText(string jsonText)
        {
            var output = this.Deserialize_FromJsonText(
                jsonText,
                this.TextHandlerSuites_ByTypeName);

            return output;
        }

        public TDescriptor From_JsonSerializationObject(JsonSerializationObject jsonSerializationObject)
        {
            var output = this.From_JsonSerializationObject(
                jsonSerializationObject,
                this.TextHandlerSuites_ByTypeName);

            return output;
        }

        public IEnumerable<JsonSerializationObject> Enumerate_JsonSerializationObjects(
            IEnumerable<TDescriptor> descriptors,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var output = descriptors
                .Select(descriptor => this.To_JsonSerializationObject(
                    descriptor,
                    handlerSuites_ByType)
                )
                ;

            return output;
        }

        public JsonSerializationObject To_JsonSerializationObject(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                return Instances.JsonOperator.Get_JsonSerializationObject_ForNull();
            }

            var handlerSuite = Instances.HandlerSuiteOperator.Verify_CanHandle(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.JsonOperator.To_JsonSerializationObject(
                descriptor,
                handlerSuite.To_JsonElement);

            return output;
        }

        public async Task Serialize_ToJsonFile(
            string jsonFilePath,
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var jsonSerializationObject = this.To_JsonSerializationObject(
                descriptor,
                handlerSuites_ByType);

            await Instances.JsonOperator.Serialize(
                jsonFilePath,
                jsonSerializationObject);
        }

        public async Task Serialize_ToJsonFile(
            string jsonFilePath,
            IEnumerable<TDescriptor> descriptors,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var jsonSerializationObjects = this.Enumerate_JsonSerializationObjects(
                descriptors,
                handlerSuites_ByType);

            await Instances.JsonOperator.Serialize(
                jsonFilePath,
                jsonSerializationObjects);
        }

        public Task Serialize_ToJsonFile(
            string jsonFilePath,
            IEnumerable<TDescriptor> descriptors)
        {
            return this.Serialize_ToJsonFile(
                jsonFilePath,
                descriptors,
                this.TextHandlerSuites_ByType);
        }

        public string Serialize_ToJsonText(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var jsonSerializationObject = this.To_JsonSerializationObject(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.JsonOperator.Serialize_ToText(jsonSerializationObject);
            return output;
        }

        public Task Serialize_ToJsonFile(
            string jsonFilePath,
            TDescriptor descriptor)
            => this.Serialize_ToJsonFile(
                jsonFilePath,
                descriptor,
                this.TextHandlerSuites_ByType);

        public string Serialize_ToJsonText(
            TDescriptor descriptor)
            => this.Serialize_ToJsonText(
                descriptor,
                this.TextHandlerSuites_ByType);

        public JsonSerializationObject To_JsonSerializationObject(TDescriptor descriptor)
        {
            var output = this.To_JsonSerializationObject(
                descriptor,
                this.TextHandlerSuites_ByType);

            return output;
        }

        public For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<TDescriptor>>
            To_Text_AsResult(
            TDescriptor descriptor)
        {
            var output = this.To_Text_AsResult(
                descriptor,
                this.TextHandlerSuites_ByType);

            return output;
        }

        public For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<TDescriptor>[]>
            To_Text_AsResult(
            IEnumerable<TDescriptor> descriptors)
        {
            var output = this.To_Text_AsResult(
                descriptors,
                this.TextHandlerSuites_ByType);

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly_Noexceptive(TDescriptor descriptor)
        {
            var output = this.To_Text_ContentOnly_Noexceptive(
                descriptor,
                this.TextHandlerSuites_ByType);

            return output;
        }

        public IEnumerable<string> To_Text_Noexceptive(TDescriptor descriptor)
        {
            var output = this.To_Text_Noexceptive(
                descriptor,
                this.TextHandlerSuites_ByType);

            return output;
        }

        public For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<TDescriptor>>
            To_Text_AsResult(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            if (can_Handle)
            {
                var lines = handlerSuite_OrDefault.To_Text(descriptor);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>>
                {
                    Is_Success = true,
                    Success = lines,
                };

                return output;
            }
            else
            {
                var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<TDescriptor>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = descriptor
                    }
                };

                return output;
            }
        }

        public For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<TDescriptor>>
            To_Text_ContentOnly_AsResult(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var isNull = Instances.NullOperator.Is_Null(descriptor);
            if (isNull)
            {
                var message = $"Descriptor was {Instances.Texts.null_Bracketed}.";

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<TDescriptor>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = descriptor
                    }
                };

                return output;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                descriptor,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            if (can_Handle)
            {
                var lines = handlerSuite_OrDefault.To_Text_ContentOnly(descriptor);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>>
                {
                    Is_Success = true,
                    Success = lines,
                };

                return output;
            }
            else
            {
                var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<TDescriptor>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = descriptor
                    }
                };

                return output;
            }
        }

        public IEnumerable<string> To_Text_ContentOnly_Noexceptive(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var result = this.To_Text_ContentOnly_AsResult(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.ResultOperator.Get_Lines_ForOutput(result);
            return output;
        }

        public IEnumerable<string> To_Text_Noexceptive(
            TDescriptor descriptor,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var result = this.To_Text_AsResult(
                descriptor,
                handlerSuites_ByType);

            var output = Instances.ResultOperator.Get_Lines_ForOutput(result);
            return output;
        }

        public For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<TDescriptor>[]>
            To_Text_AsResult(
            IEnumerable<TDescriptor> descriptors,
            Dictionary<Type, DescriptorTextOperationHandlerSuite<TDescriptor>> handlerSuites_ByType)
        {
            var descriptors_Actual = descriptors.ToArray();

            var can_Handle_Results = Instances.HandlerSuiteOperator.Can_Handle(
                descriptors_Actual as IEnumerable<TDescriptor>,
                handlerSuites_ByType);

            var failures = can_Handle_Results
                .Where(x => !x.Success)
                .Select(result =>
                {
                    var descriptor = result.Input;

                    var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

                    var output = new For_Results.N002.Failed<TDescriptor>
                    {
                        Value = descriptor,
                        Message_Lines = Instances.EnumerableOperator.From(message),
                    };

                    return output;
                })
                .ToArray();

            var is_Success = failures.Any();

            var successes = can_Handle_Results
                .Where(x => x.Success)
                ;

            var any_Successes = successes.Any();

            var successes_Lines = any_Successes
                ? successes
                    .SelectMany(result =>
                    {
                        var descriptor = result.Input;

                        var lines = result.Output.To_Text(descriptor);
                        return lines;
                    })
                : Instances.EnumerableOperator.From("<No results>")
                ;

            var descriptors_Count = Instances.ArrayOperator.Get_Count(descriptors_Actual);

            var output_Lines = Instances.EnumerableOperator.From($"Descriptor count: {descriptors_Count}\n")
                .Append_Many(successes_Lines)
                ;

            var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<TDescriptor>[]>
            {
                Is_Success = true,
                Success = output_Lines,
                Failure = failures
            };

            return output;
        }
    }
}
