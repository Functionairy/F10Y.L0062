using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0062.L002
{
    [DataTypeMarker]
    public interface ITextSerializationHandlerSuite<THandled>
    {
        public Func<THandled, IEnumerable<string>> To_Text_ContentOnly { get; set; }
        public Func<THandled, IEnumerable<string>> To_Text { get; set; }
    }
}
