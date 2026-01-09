using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002.N001
{
    [FunctionsMarker]
    public partial interface ITextSerializationHandlerSuiteOperator<THandled, THandlerSuite> :
        IHandlerSuiteOperator
        where THandlerSuite : ITextSerializationHandlerSuite<THandled>
    {
        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>>
            To_Text_AsResult(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var can_Handle = this.Can_Handle(
                handled,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            if (can_Handle)
            {
                var lines = handlerSuite_OrDefault.To_Text(handled);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>>
                {
                    Is_Success = true,
                    Success = lines,
                };

                return output;
            }
            else
            {
                var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(handled);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<THandled>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = handled
                    }
                };

                return output;
            }
        }

        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>>
            To_Text_ContentOnly_AsResult(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var isNull = Instances.NullOperator.Is_Null(handled);
            if (isNull)
            {
                var message = $"Descriptor was {Instances.Texts.null_Bracketed}.";

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<THandled>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = handled
                    }
                };

                return output;
            }

            var can_Handle = Instances.HandlerSuiteOperator.Can_Handle(
                handled,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            if (can_Handle)
            {
                var lines = handlerSuite_OrDefault.To_Text_ContentOnly(handled);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>>
                {
                    Is_Success = true,
                    Success = lines,
                };

                return output;
            }
            else
            {
                var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(handled);

                var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>>
                {
                    Is_Success = false,
                    Failure = new For_Results.N002.Failed<THandled>
                    {
                        Message_Lines = Instances.EnumerableOperator.From(message),
                        Value = handled
                    }
                };

                return output;
            }
        }

        IEnumerable<string> To_Text_ContentOnly_Noexceptive(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var result = this.To_Text_ContentOnly_AsResult(
                handled,
                handlerSuites_ByType);

            var output = Instances.ResultOperator.Get_Lines_ForOutput(result);
            return output;
        }

        IEnumerable<string> To_Text_Noexceptive(
            THandled handled,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var result = this.To_Text_AsResult(
                handled,
                handlerSuites_ByType);

            var output = Instances.ResultOperator.Get_Lines_ForOutput(result);
            return output;
        }

        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>[]>
            To_Text_AsResult(
            IEnumerable<THandled> handleds,
            IDictionary<Type, THandlerSuite> handlerSuites_ByType)
        {
            var descriptors_Actual = handleds.ToArray();

            var can_Handle_Results = Instances.HandlerSuiteOperator.Can_Handle(
                descriptors_Actual as IEnumerable<THandled>,
                handlerSuites_ByType);

            var failures = can_Handle_Results
                .Where(x => !x.Success)
                .Select(result =>
                {
                    var descriptor = result.Input;

                    var message = Instances.ExceptionMessageOperator.Get_NoHandlerSuiteFoundForDescriptorTypeExceptionMessage(descriptor);

                    var output = new For_Results.N002.Failed<THandled>
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

            var output = new For_Results.N003.Result<IEnumerable<string>, For_Results.N002.IFailed<THandled>[]>
            {
                Is_Success = true,
                Success = output_Lines,
                Failure = failures
            };

            return output;
        }
    }
}
