using System;


namespace F10Y.L0062.L003
{
    public class StringSearchDescriptorHandlers : IStringSearchDescriptorHandlers
    {
        #region Infrastructure

        public static IStringSearchDescriptorHandlers Instance { get; } = new StringSearchDescriptorHandlers();


        private StringSearchDescriptorHandlers()
        {
        }

        #endregion
    }
}
