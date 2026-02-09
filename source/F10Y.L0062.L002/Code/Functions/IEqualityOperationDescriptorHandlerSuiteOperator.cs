using System;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface IEqualityOperationDescriptorHandlerSuiteOperator
    {
        EqualityOperationDescriptorHandlerSuite<TValue> From<TValue>(
            EqualityOperationDescriptorHandlerSuite handlerSuite,
            Func<IEqualityOperationDescriptor, Func<TValue, TValue, bool>> getPredicate)
        {
            EqualityOperationDescriptorHandlerSuite<TValue> output = new()
            {
                Equality_Predicate = handlerSuite.Equality_Predicate,
                From_JsonElement = handlerSuite.From_JsonElement,
                Get_HashCode = handlerSuite.Get_HashCode,
                Get_Predicate = getPredicate,
                To_JsonElement = handlerSuite.To_JsonElement,
                To_Text = handlerSuite.To_Text,
                To_Text_ContentOnly = handlerSuite.To_Text_ContentOnly,
                Type = handlerSuite.Type
            };

            return output;
        }
    }
}
