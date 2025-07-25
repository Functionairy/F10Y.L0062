using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0062
{
    [FunctionsMarker]
    public partial interface ITypeOperator :
        L0001.ITypeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0001.ITypeOperator _L0001 => L0001.TypeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public void Verify_TypeName<T>(IHas_TypeName has_TypeName)
            => this.Verify_TypeName<T>(
                has_TypeName.TypeName);
    }
}
