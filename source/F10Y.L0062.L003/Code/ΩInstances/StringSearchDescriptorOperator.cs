using System;


namespace F10Y.L0062.L003
{
    public class StringSearchDescriptorOperator : IStringSearchDescriptorOperator
    {
        #region Infrastructure

        public static IStringSearchDescriptorOperator Instance { get; } = new StringSearchDescriptorOperator();


        private StringSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
