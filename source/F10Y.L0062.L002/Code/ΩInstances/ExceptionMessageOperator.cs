using System;


namespace F10Y.L0062.L002
{
    public class ExceptionMessageOperator : IExceptionMessageOperator
    {
        #region Infrastructure

        public static IExceptionMessageOperator Instance { get; } = new ExceptionMessageOperator();


        private ExceptionMessageOperator()
        {
        }

        #endregion
    }
}
