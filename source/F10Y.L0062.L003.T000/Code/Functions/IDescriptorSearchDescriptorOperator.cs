using System;

using F10Y.T0002;


namespace F10Y.L0062.L003.T000
{
    [FunctionsMarker]
    public partial interface IDescriptorSearchDescriptorOperator
    {
        public DescriptorSearchDescriptor_Name_Simple From_Name(string name)
        {
            var output = new DescriptorSearchDescriptor_Name_Simple
            {
                Name = name,
            };

            return output;
        }
    }
}
