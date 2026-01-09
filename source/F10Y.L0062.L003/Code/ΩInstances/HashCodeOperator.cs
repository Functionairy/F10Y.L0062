using System;


namespace F10Y.L0062.L003
{
    public class HashCodeOperator : IHashCodeOperator
    {
        #region Infrastructure

        public static IHashCodeOperator Instance { get; } = new HashCodeOperator();


        private HashCodeOperator()
        {
        }

        #endregion
    }
}
