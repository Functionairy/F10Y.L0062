using System;


namespace F10Y.L0062.L002
{
    public class DescriptorHandlers : IDescriptorHandlers
    {
        #region Infrastructure

        public static IDescriptorHandlers Instance { get; } = new DescriptorHandlers();


        private DescriptorHandlers()
        {
        }

        #endregion
    }
}
