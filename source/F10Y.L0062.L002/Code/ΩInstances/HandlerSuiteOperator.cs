using System;


namespace F10Y.L0062.L002
{
    public class HandlerSuiteOperator : IHandlerSuiteOperator
    {
        #region Infrastructure

        public static IHandlerSuiteOperator Instance { get; } = new HandlerSuiteOperator();


        private HandlerSuiteOperator()
        {
        }

        #endregion
    }
}
