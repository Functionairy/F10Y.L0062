using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.T000
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator
    {
        public SetEqualityOperationDescriptor From(
            IEqualityOperationDescriptor element_EqualityOperationDescriptor,
            OrderDependence orderDependence)
        {
            var output = new SetEqualityOperationDescriptor
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDescriptor,
                OrderDependence = orderDependence,
            };

            return output;
        }

        public SetEqualityOperationDescriptor_Intersection From(
            IEqualityOperationDescriptor element_EqualityOperationDescriptor,
            AnyOrNone anyOrNone)
        {
            var output = new SetEqualityOperationDescriptor_Intersection
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDescriptor,
                AnyOrNone = anyOrNone,
            };

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element_EqualityOperationDescriptor"></param>
        /// <param name="containment">Is a set a subset or superset of the specified search set?</param>
        /// <param name="contiguity"></param>
        /// <param name="orderDependence"></param>
        /// <param name="inclusiveness">Inclusive of sets that are equal to the search set?</param>
        /// <returns></returns>
        public SetEqualityOperationDescriptor_Containment From(
            IEqualityOperationDescriptor element_EqualityOperationDescriptor,
            Containment containment,
            Contiguity contiguity,
            OrderDependence orderDependence,
            Inclusiveness inclusiveness)
        {
            var output = new SetEqualityOperationDescriptor_Containment
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDescriptor,
                Containment = containment,
                Contiguity = contiguity,
                Inclusiveness = inclusiveness,
                OrderDependence = orderDependence,
            };

            return output;
        }
    }
}
