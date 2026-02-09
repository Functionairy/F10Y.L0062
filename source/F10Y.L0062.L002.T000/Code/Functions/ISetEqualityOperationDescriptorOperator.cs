using System;

using F10Y.T0002;


namespace F10Y.L0062.L002.T000
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator
    {
        SetEqualityOperationDescriptor From(
            IEqualityOperationDescriptor element_EqualityOperationDescriptor,
            OrderDependence orderDependence = OrderDependence.OrderIndependent)
        {
            var output = new SetEqualityOperationDescriptor
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDescriptor,
                OrderDependence = orderDependence,
            };

            return output;
        }

        SetEqualityOperationDescriptor From_OrderDependent(IEqualityOperationDescriptor element_EqualityOperationDescriptor)
            => this.From(
                element_EqualityOperationDescriptor,
                OrderDependence.OrderDependent);

        SetEqualityOperationDescriptor From_OrderIndependent(IEqualityOperationDescriptor element_EqualityOperationDescriptor)
            => this.From(
                element_EqualityOperationDescriptor,
                OrderDependence.OrderIndependent);

        SetEqualityOperationDescriptor_Intersection From(
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

        SetEqualityOperationDescriptor_Intersection From_AnyIntersection(IEqualityOperationDescriptor element_EqualityOperationDescriptor)
            => this.From(
                element_EqualityOperationDescriptor,
                AnyOrNone.Any);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element_EqualityOperationDescriptor"></param>
        /// <param name="containment"><inheritdoc cref="SetEqualityOperationDescriptor_Containment.Containment" path="/summary"/></param>
        /// <param name="contiguity"><inheritdoc cref="SetEqualityOperationDescriptor_Containment.Contiguity" path="/summary"/></param>
        /// <param name="orderDependence"><inheritdoc cref="SetEqualityOperationDescriptor_Containment.OrderDependence" path="/summary"/></param>
        /// <param name="inclusiveness"><inheritdoc cref="SetEqualityOperationDescriptor_Containment.Inclusiveness" path="/summary"/></param>
        /// <returns></returns>
        SetEqualityOperationDescriptor_Containment From(
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
