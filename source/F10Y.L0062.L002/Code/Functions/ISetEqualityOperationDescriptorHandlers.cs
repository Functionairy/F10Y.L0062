using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorHandlers
    {
        Func<TValue[], TValue[], bool> Get_PredicateFor<TValue>(
            SetEqualityOperationDescriptor setEqualityOperationDescriptor,
            IEqualityComparer<TValue> equalityComparer)
        {
            bool Internal(
                TValue[] a,
                TValue[] b)
            {
                if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                {
                    // Is set A equal to set B, with order dependence? (Same number of elements, in the same order?)
                    var output = Instances.ArrayOperator.Are_Equal_OrderDependent(a, b, equalityComparer);
                    return output;
                }
                else
                {
                    // Is set A equal to set B, without order dependence? (Contains the same elements?)
                    var output = Instances.ArrayOperator.Are_Equal_OrderIndependent(a, b, equalityComparer);
                    return output;
                }
            }

            return Internal;
        }

        Func<string[], string[], bool> Get_PredicateFor_String(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_String.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);
            Func<string, int> element_HashCodeOperator = Instances.HashCodeOperator.Get_HashCode;

            var equalityComparer = Instances.EqualityComparerOperator.From(
                element_EqualityOperation,
                element_HashCodeOperator);

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                equalityComparer);

            return output;
        }

        Func<int[], int[], bool> Get_PredicateFor_Integer(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_Integer.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);
            Func<int, int> element_HashCodeOperator = Instances.HashCodeOperator.Get_HashCode;

            var equalityComparer = Instances.EqualityComparerOperator.From(
                element_EqualityOperation,
                element_HashCodeOperator);

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                equalityComparer);

            return output;
        }

        /// <summary>
        /// Is set A a subset of set B?
        /// </summary>
        Func<TValue[], TValue[], bool> Get_PredicateFor<TValue>(
            SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor,
            Func<TValue, TValue, bool> element_EqualityOperation,
            Func<TValue, int> element_HashCodeOperation)
        {
            var element_EqualityComparer = Instances.EqualityComparerOperator.From(
                element_EqualityOperation,
                element_HashCodeOperation);

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_Contiguous_OrderDependent(
                TValue[] subset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains(
                    set,
                    subset_Potential,
                    element_EqualityOperation);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_Contiguous_OrderIndependent(
                TValue[] subset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_Contiguous_OrderIndependent(
                    set,
                    subset_Potential,
                    element_EqualityComparer);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_NonContiguous_OrderDependent(
                TValue[] subset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderDependent(
                    set,
                    subset_Potential,
                    element_EqualityOperation);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_NonContiguous_OrderIndependent(
                TValue[] subset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderIndependent(
                    set,
                    subset_Potential,
                    element_EqualityComparer);

                return output;
            }

            bool Superset_Contiguous_OrderDependent(
                TValue[] superset_Potential,
                TValue[] set)
            {
                // Is set A a superset of set B?
                // I.e. does A contain B?
                var output = Instances.ArrayOperator.Contains(
                    superset_Potential,
                    set,
                    element_EqualityOperation);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_Contiguous_OrderIndependent(
                TValue[] superset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_Contiguous_OrderIndependent(
                    superset_Potential,
                    set,
                    element_EqualityComparer);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_NonContiguous_OrderDependent(
                TValue[] superset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderDependent(
                    superset_Potential,
                    set,
                    element_EqualityOperation);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_NonContiguous_OrderIndependent(
                TValue[] superset_Potential,
                TValue[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderIndependent(
                    superset_Potential,
                    set,
                    element_EqualityComparer);

                return output;
            }

            bool Internal(
                TValue[] a,
                TValue[] b)
            {
                if (setEqualityOperationDescriptor.Inclusiveness == Inclusiveness.Exclusive)
                {
                    // If the two sets are equal in element count, then false.
                    var count_A = Instances.ArrayOperator.Get_Count(a);
                    var count_B = Instances.ArrayOperator.Get_Count(b);

                    if (count_A == count_B)
                    {
                        return false;
                    }
                }
                // Else, if the inclusiveness is inclusive, we don't care about set element count.

                if (setEqualityOperationDescriptor.Containment == Containment.Sub)
                {
                    if (setEqualityOperationDescriptor.Contiguity == Contiguity.Contiguous)
                    {
                        if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                        {
                            var output = Subset_Contiguous_OrderDependent(a, b);
                            return output;
                        }
                        else
                        {
                            var output = Subset_Contiguous_OrderIndependent(a, b);
                            return output;
                        }
                    }
                    else
                    {
                        if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                        {
                            var output = Subset_NonContiguous_OrderDependent(a, b);
                            return output;
                        }
                        else
                        {
                            var output = Subset_NonContiguous_OrderIndependent(a, b);
                            return output;
                        }
                    }
                }
                else // Superset.
                {
                    if (setEqualityOperationDescriptor.Contiguity == Contiguity.Contiguous)
                    {
                        if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                        {
                            var output = Superset_Contiguous_OrderDependent(a, b);
                            return output;
                        }
                        else
                        {
                            var output = Superset_Contiguous_OrderIndependent(a, b);
                            return output;
                        }
                    }
                    else
                    {
                        if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                        {
                            var output = Superset_NonContiguous_OrderDependent(a, b);
                            return output;
                        }
                        else
                        {
                            var output = Superset_NonContiguous_OrderIndependent(a, b);
                            return output;
                        }
                    }
                }
            }

            return Internal;
        }

        /// <summary>
        /// Is set A a subset of set B?
        /// </summary>
        Func<string[], string[], bool> Get_PredicateFor_String(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_String.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);
            Func<string, int> element_HashCodeOperation = Instances.HashCodeOperator.Get_HashCode;

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                element_EqualityOperation,
                element_HashCodeOperation);

            return output;
        }

        /// <summary>
        /// Is set A a subset of set B?
        /// </summary>
        Func<int[], int[], bool> Get_PredicateFor_Integer(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_Integer.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);
            Func<int, int> element_HashCodeOperation = Instances.HashCodeOperator.Get_HashCode;

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                element_EqualityOperation,
                element_HashCodeOperation);

            return output;
        }

        Func<TValue[], TValue[], bool> Get_PredicateFor<TValue>(
            SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor,
            Func<TValue, TValue, bool> element_EqualityOperation)
        {
            bool Internal(
                TValue[] a,
                TValue[] b)
            {
                // Are any of the elements in set A in set B?
                var intersection_Any = a.Intersect(b).Any();

                var isAny = setEqualityOperationDescriptor.AnyOrNone == AnyOrNone.Any;

                var output = isAny
                    // If any, true.
                    ? intersection_Any
                    // If none, false.
                    : !intersection_Any
                    ;

                return output;
            }

            return Internal;
        }

        Func<string[], string[], bool> Get_PredicateFor_String(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_String.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                element_EqualityOperation);

            return output;
        }

        Func<int[], int[], bool> Get_PredicateFor_Integer(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EqualityOperation = Instances.EqualityOperationDescriptorOperator.For_Integer.Get_Predicate(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var output = this.Get_PredicateFor(
                setEqualityOperationDescriptor,
                element_EqualityOperation);

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly_ForString(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptorLines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var orderDependence_Token = Instances.OrderDependenceOperator.To_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = Instances.EnumerableOperator.From($"{orderDependence_Token}: order-dependence")
                .Append_Many(Instances.EnumerableOperator.From("Element Equality Operation:")
                    .Append_Many(element_EqualityOperationDesriptorLines.Entab())
                )
                ;

            return output;
        }

        IEnumerable<string> To_Text(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly_ForString(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        SetEqualityOperationDescriptor From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var orderDependence = Instances.OrderDependenceOperator.From_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = new SetEqualityOperationDescriptor
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                OrderDependence = orderDependence
            };

            return output;
        }

        For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor To_SerializationType(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var orderDependence = Instances.OrderDependenceOperator.To_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = new For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                OrderDependence = orderDependence,
            };

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptorLines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var containment_Token = Instances.StringOperator.Concatenate(
                Instances.ContainmentOperator.To_String_Standard(setEqualityOperationDescriptor.Containment),
                "set"); // Subset or Superset.
            var contiguity_Token = Instances.ContiguityOperator.To_String_Standard(setEqualityOperationDescriptor.Contiguity);
            var inclusiveness_Token = Instances.InclusivenessOperator.To_String_Standard(setEqualityOperationDescriptor.Inclusiveness);
            var orderDependence_Token = Instances.OrderDependenceOperator.To_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = Instances.EnumerableOperator.Empty<string>()
                .Append($"{containment_Token}: containment")
                .Append($"{contiguity_Token}: contiguity")
                .Append($"{inclusiveness_Token}: inclusiveness")
                .Append($"{orderDependence_Token}: order-dependence")
                .Append_Many(Instances.EnumerableOperator.From("Element Equality Operation:")
                    .Append_Many(element_EqualityOperationDesriptorLines.Entab())
                )
                ;

            return output;
        }

        IEnumerable<string> To_Text(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        SetEqualityOperationDescriptor_Containment From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var containment = Instances.ContainmentOperator.From_String_Standard(setEqualityOperationDescriptor.Containment);
            var contiguity = Instances.ContiguityOperator.From_String_Standard(setEqualityOperationDescriptor.Contiguity);
            var inclusiveness = Instances.InclusivenessOperator.From_String_Standard(setEqualityOperationDescriptor.Inclusiveness);
            var orderDependence = Instances.OrderDependenceOperator.From_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = new SetEqualityOperationDescriptor_Containment
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                Containment = containment,
                Contiguity = contiguity,
                Inclusiveness = inclusiveness,
                OrderDependence = orderDependence,
            };

            return output;
        }

        For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment To_SerializationType(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var containment = Instances.ContainmentOperator.To_String_Standard(setEqualityOperationDescriptor.Containment);
            var contiguity = Instances.ContiguityOperator.To_String_Standard(setEqualityOperationDescriptor.Contiguity);
            var inclusiveness = Instances.InclusivenessOperator.To_String_Standard(setEqualityOperationDescriptor.Inclusiveness);
            var orderDependence = Instances.OrderDependenceOperator.To_String_Standard(setEqualityOperationDescriptor.OrderDependence);

            var output = new For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                Containment = containment,
                Contiguity = contiguity,
                Inclusiveness = inclusiveness,
                OrderDependence = orderDependence,
            };

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptorLines = Instances.EqualityOperationDescriptorOperator.To_Text_ContentOnly_Noexceptive(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var orderDependence_Token = Instances.AnyOrNoneOperator.To_String_Standard(setEqualityOperationDescriptor.AnyOrNone);

            var output = Instances.EnumerableOperator.From($"{orderDependence_Token}: order-dependence")
                .Append_Many(Instances.EnumerableOperator.From("Element Equality Operation:")
                    .Append_Many(element_EqualityOperationDesriptorLines.Entab())
                )
                ;

            return output;
        }

        IEnumerable<string> To_Text(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        SetEqualityOperationDescriptor_Intersection From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.From_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var anyOrNone = Instances.AnyOrNoneOperator.From_String_Standard(setEqualityOperationDescriptor.AnyOrNone);

            var output = new SetEqualityOperationDescriptor_Intersection
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                AnyOrNone = anyOrNone,
            };

            return output;
        }

        For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection To_SerializationType(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EqualityOperationDesriptor = Instances.EqualityOperationDescriptorOperator.To_JsonSerializationObject(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            var anyOrNone = Instances.AnyOrNoneOperator.To_String_Standard(setEqualityOperationDescriptor.AnyOrNone);

            var output = new For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection
            {
                Element_EqualityOperationDescriptor = element_EqualityOperationDesriptor,
                AnyOrNone = anyOrNone,
            };

            return output;
        }
    }
}
