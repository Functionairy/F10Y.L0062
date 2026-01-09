using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ITextSerializationHandlerSuiteOperator<THandled, THandlerSuite> :
        N001.IHandlerSuiteOperator<THandled, THandlerSuite>,
        N001.ITextSerializationHandlerSuiteOperator<THandled, THandlerSuite>
        where THandlerSuite : ITextSerializationHandlerSuite<THandled>
    {
        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>>
            To_Text_AsResult(
            THandled descriptor)
            => this.To_Text_AsResult(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>>
            To_Text_ContentOnly_AsResult(
            THandled descriptor)
            => this.To_Text_ContentOnly_AsResult(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        IEnumerable<string> To_Text_ContentOnly_Noexceptive(THandled descriptor)
            => this.To_Text_ContentOnly_Noexceptive(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        IEnumerable<string> To_Text_Noexceptive(THandled descriptor)
            => this.To_Text_Noexceptive(
                descriptor,
                this.HandlerSuites_ByHandledImplementationType);

        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<THandled>[]>
            To_Text_AsResult(
            IEnumerable<THandled> descriptors)
            => this.To_Text_AsResult(
                descriptors,
                this.HandlerSuites_ByHandledImplementationType);
    }
}
