using System;


namespace F10Y.L0062.L002.T000
{
    public class Descriptor : IDescriptor,
        IEquatable<Descriptor>,
        IWith_Identity_AsGuid,
        IWith_Name,
        IWith_Description
    {
        public Guid Identity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is Descriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(Descriptor other)
        {
            var output = true
                && Object.Equals(this.Identity, other.Identity)
                && Object.Equals(this.Name, other.Name)
                && Object.Equals(this.Description, other.Description)
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(
                this.Identity,
                this.Name,
                this.Description);

            return output;
        }
    }
}
