using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0062.L002.T000;


namespace F10Y.L0062.L002
{
    [FunctionsMarker]
    public partial interface ISetEqualityOperationDescriptorOperator :
        T000.ISetEqualityOperationDescriptorOperator,
        Bases.IDescriptorTextOperator<ISetEqualityOperationDescriptor>,
        Bases.IBinaryPredicateOperator<ISetEqualityOperationDescriptor, string[]>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T000.ISetEqualityOperationDescriptorOperator _T000 => T000.SetEqualityOperationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ISetEqualityOperationDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_SetEqualityOperationDescriptors_ByType;

        Dictionary<string, DescriptorTextOperationHandlerSuite<ISetEqualityOperationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ISetEqualityOperationDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_SetEqualityOperationDescriptors_ByTypeName;

        Dictionary<Type, BinaryPredicateProviderSuite<ISetEqualityOperationDescriptor, string[]>> Bases.IBinaryPredicateOperator<ISetEqualityOperationDescriptor, string[]>.BinaryPredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_SetEqualityOperationDescriptors_OfString_ByType;


        public Func<string[], string[], bool> Get_PredicateFor(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var element_EequalityOperation = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            bool Internal(
                string[] a,
                string[] b)
            {
                if (setEqualityOperationDescriptor.OrderDependence == OrderDependence.OrderDependent)
                {
                    // Is set A equal to set B, with order dependence? (Same number of elements, in the same order?)
                    var output = Instances.ArrayOperator.Are_Equal_OrderDependent(a, b);
                    return output;
                }
                else
                {
                    // Is set A equal to set B, without order dependence? (Contains the same elements?)
                    var output = Instances.ArrayOperator.Are_Equal_OrderIndependent(a, b);
                    return output;
                }
            }

            return Internal;
        }

        /// <summary>
        /// Is set A a subset of set B?
        /// </summary>
        public Func<string[], string[], bool> Get_PredicateFor(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var element_EequalityOperation = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_Contiguous_OrderDependent(
                string[] subset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains(
                    set,
                    subset_Potential);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_Contiguous_OrderIndependent(
                string[] subset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_Contiguous_OrderIndependent(
                    set,
                    subset_Potential);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_NonContiguous_OrderDependent(
                string[] subset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderDependent(
                    set,
                    subset_Potential);

                return output;
            }

            // Is set A a subset of set B?
            // I.e. does B contain A?
            bool Subset_NonContiguous_OrderIndependent(
                string[] subset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderIndependent(
                    set,
                    subset_Potential);

                return output;
            }

            bool Superset_Contiguous_OrderDependent(
                string[] superset_Potential,
                string[] set)
            {
                // Is set A a superset of set B?
                // I.e. does A contain B?
                var output = Instances.ArrayOperator.Contains(
                    superset_Potential,
                    set);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_Contiguous_OrderIndependent(
                string[] superset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_Contiguous_OrderIndependent(
                    superset_Potential,
                    set);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_NonContiguous_OrderDependent(
                string[] superset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderDependent(
                    superset_Potential,
                    set);

                return output;
            }

            // Is set A a superset of set B?
            // I.e. does A contain B?
            bool Superset_NonContiguous_OrderIndependent(
                string[] superset_Potential,
                string[] set)
            {
                var output = Instances.ArrayOperator.Contains_NonContiguous_OrderIndependent(
                    superset_Potential,
                    set);

                return output;
            }

            bool Internal(
                string[] a,
                string[] b)
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

        public Func<string[], string[], bool> Get_PredicateFor(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var element_EequalityOperation = Instances.EqualityOperationDescriptorOperator.Get_Predicate_Synchronous(setEqualityOperationDescriptor.Element_EqualityOperationDescriptor);

            bool Internal(
                string[] a,
                string[] b)
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

        public IEnumerable<string> To_Text_ContentOnly(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
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

        public IEnumerable<string> To_Text(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public SetEqualityOperationDescriptor From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor setEqualityOperationDescriptor)
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

        public For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor To_SerializationType(SetEqualityOperationDescriptor setEqualityOperationDescriptor)
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

        public IEnumerable<string> To_Text_ContentOnly(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
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

        public IEnumerable<string> To_Text(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public SetEqualityOperationDescriptor_Containment From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
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

        public For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Containment To_SerializationType(SetEqualityOperationDescriptor_Containment setEqualityOperationDescriptor)
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

        public IEnumerable<string> To_Text_ContentOnly(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
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

        public IEnumerable<string> To_Text(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(setEqualityOperationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(setEqualityOperationDescriptor);

            var output = Instances.EnumerableOperator.From($"Set Equality Operation Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public SetEqualityOperationDescriptor_Intersection From_SerializationType(For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
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

        public For_SetEqualityOperationDescriptors.Serialization.SetEqualityOperationDescriptor_Intersection To_SerializationType(SetEqualityOperationDescriptor_Intersection setEqualityOperationDescriptor)
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
