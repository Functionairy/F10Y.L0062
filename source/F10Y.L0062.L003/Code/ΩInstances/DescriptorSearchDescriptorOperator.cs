using System;


namespace F10Y.L0062.L003
{
    public class DescriptorSearchDescriptorOperator : IDescriptorSearchDescriptorOperator
    {
        #region Infrastructure

        public static IDescriptorSearchDescriptorOperator Instance { get; } = new DescriptorSearchDescriptorOperator();


        private DescriptorSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
