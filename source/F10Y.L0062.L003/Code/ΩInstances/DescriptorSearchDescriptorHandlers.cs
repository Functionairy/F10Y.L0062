using System;


namespace F10Y.L0062.L003
{
    public class DescriptorSearchDescriptorHandlers : IDescriptorSearchDescriptorHandlers
    {
        #region Infrastructure

        public static IDescriptorSearchDescriptorHandlers Instance { get; } = new DescriptorSearchDescriptorHandlers();


        private DescriptorSearchDescriptorHandlers()
        {
        }

        #endregion
    }
}
