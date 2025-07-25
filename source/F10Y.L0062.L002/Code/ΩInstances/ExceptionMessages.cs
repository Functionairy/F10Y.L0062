using System;


namespace F10Y.L0062.L002
{
    public class ExceptionMessages : IExceptionMessages
    {
        #region Infrastructure

        public static IExceptionMessages Instance { get; } = new ExceptionMessages();


        private ExceptionMessages()
        {
        }

        #endregion
    }
}
