using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.T000
{
    [FunctionsMarker]
    public partial interface IDescriptorOperator
    {
        public Descriptor From(
            string name,
            string description,
            Guid identity)
        {
            var output = new Descriptor
            {
                Description = description,
                Identity = identity,
                Name = name,
            };

            return output;
        }

        public Descriptor From(
            string name,
            string description,
            string identity)
        {
            var identity_Guid = Instances.GuidOperator.From(identity);

            var output = this.From(
                name,
                description,
                identity_Guid);

            return output;
        }

        public Guid Get_Identity(string identityString)
            => Instances.GuidOperator.From(identityString);

        public Descriptor To_Descriptor(IDescriptor descriptor)
        {
            var output = new Descriptor
            {
                Description = descriptor.Description,
                Identity = descriptor.Identity,
                Name = descriptor.Name
            };

            return output;
        }
    }
}
