using System;


namespace F10Y.L0062.L001
{
    public static class Instances
    {
        public static L0060.IJsonElementOperator JsonElementOperator => L0060.JsonElementOperator.Instance;
        public static IJsonOperator JsonOperator => L001.JsonOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0000.ITypeOperator TypeOperator => L0000.TypeOperator.Instance;
    }
}