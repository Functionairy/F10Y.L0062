using System;


namespace F10Y.L0062
{
    public class TypeOperator : ITypeOperator
    {
        #region Infrastructure

        public static ITypeOperator Instance { get; } = new TypeOperator();


        private TypeOperator()
        {
        }

        #endregion
    }
}
