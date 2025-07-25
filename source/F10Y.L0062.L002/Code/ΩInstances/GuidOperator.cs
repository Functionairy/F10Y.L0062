using System;


namespace F10Y.L0062.L002
{
    public class GuidOperator : IGuidOperator
    {
        #region Infrastructure

        public static IGuidOperator Instance { get; } = new GuidOperator();


        private GuidOperator()
        {
        }

        #endregion
    }
}
