using System;


namespace F10Y.L0062.L002
{
    public class DescriptorOperator : IDescriptorOperator
    {
        #region Infrastructure

        public static IDescriptorOperator Instance { get; } = new DescriptorOperator();


        private DescriptorOperator()
        {
        }

        #endregion
    }
}
