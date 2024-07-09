// <auto-generated />
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class PrincipalDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+PrincipalDerived<Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>>",
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                baseEntityType,
                discriminatorProperty: "Discriminator",
                discriminatorValue: "PrincipalDerived<DependentBase<byte?>>",
                propertyCount: 0,
                navigationCount: 2,
                skipNavigationCount: 1);

            return runtimeEntityType;
        }

        public static RuntimeSkipNavigation CreateSkipNavigation1(RuntimeEntityType declaringEntityType, RuntimeEntityType targetEntityType, RuntimeEntityType joinEntityType)
        {
            var skipNavigation = declaringEntityType.AddSkipNavigation(
                "Principals",
                targetEntityType,
                joinEntityType.FindForeignKey(
                    new[] { joinEntityType.FindProperty("DerivedsId"), joinEntityType.FindProperty("DerivedsAlternateId") },
                    declaringEntityType.FindKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") }),
                    declaringEntityType),
                true,
                false,
                typeof(ICollection<CompiledModelTestBase.PrincipalBase>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Principals", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Principals>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var inverse = targetEntityType.FindSkipNavigation("Deriveds");
            if (inverse != null)
            {
                skipNavigation.Inverse = inverse;
                inverse.Inverse = skipNavigation;
            }

            skipNavigation.SetGetter(
                ICollection<CompiledModelTestBase.PrincipalBase> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity),
                bool (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity) == null,
                ICollection<CompiledModelTestBase.PrincipalBase> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> instance) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(instance),
                bool (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> instance) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(instance) == null);
            skipNavigation.SetSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, ICollection<CompiledModelTestBase.PrincipalBase> value) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity) = value);
            skipNavigation.SetMaterializationSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, ICollection<CompiledModelTestBase.PrincipalBase> value) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity) = value);
            skipNavigation.SetAccessors(
                ICollection<CompiledModelTestBase.PrincipalBase> (InternalEntityEntry entry) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(entry.Entity))),
                ICollection<CompiledModelTestBase.PrincipalBase> (InternalEntityEntry entry) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(entry.Entity))),
                null,
                ICollection<CompiledModelTestBase.PrincipalBase> (InternalEntityEntry entry) => entry.GetCurrentValue<ICollection<CompiledModelTestBase.PrincipalBase>>(skipNavigation),
                null);
            skipNavigation.SetPropertyIndexes(
                index: 4,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 6,
                storeGenerationIndex: -1);
            skipNavigation.SetCollectionAccessor<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>, ICollection<CompiledModelTestBase.PrincipalBase>, CompiledModelTestBase.PrincipalBase>(
                ICollection<CompiledModelTestBase.PrincipalBase> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, ICollection<CompiledModelTestBase.PrincipalBase> collection) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity) = ((ICollection<CompiledModelTestBase.PrincipalBase>)(collection)),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, ICollection<CompiledModelTestBase.PrincipalBase> collection) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Principals(entity) = ((ICollection<CompiledModelTestBase.PrincipalBase>)(collection)),
                ICollection<CompiledModelTestBase.PrincipalBase> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, Action<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>, ICollection<CompiledModelTestBase.PrincipalBase>> setter) => ClrCollectionAccessorFactory.CreateAndSetHashSet<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>, ICollection<CompiledModelTestBase.PrincipalBase>, CompiledModelTestBase.PrincipalBase>(entity, setter),
                ICollection<CompiledModelTestBase.PrincipalBase> () => ((ICollection<CompiledModelTestBase.PrincipalBase>)(((ICollection<CompiledModelTestBase.PrincipalBase>)(new HashSet<CompiledModelTestBase.PrincipalBase>(ReferenceEqualityComparer.Instance))))));
            return skipNavigation;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var alternateId = runtimeEntityType.FindProperty("AlternateId")!;
            var discriminator = runtimeEntityType.FindProperty("Discriminator")!;
            var enum1 = runtimeEntityType.FindProperty("Enum1")!;
            var enum2 = runtimeEntityType.FindProperty("Enum2")!;
            var flagsEnum1 = runtimeEntityType.FindProperty("FlagsEnum1")!;
            var flagsEnum2 = runtimeEntityType.FindProperty("FlagsEnum2")!;
            var refTypeArray = runtimeEntityType.FindProperty("RefTypeArray")!;
            var refTypeEnumerable = runtimeEntityType.FindProperty("RefTypeEnumerable")!;
            var refTypeIList = runtimeEntityType.FindProperty("RefTypeIList")!;
            var refTypeList = runtimeEntityType.FindProperty("RefTypeList")!;
            var valueTypeArray = runtimeEntityType.FindProperty("ValueTypeArray")!;
            var valueTypeEnumerable = runtimeEntityType.FindProperty("ValueTypeEnumerable")!;
            var valueTypeIList = runtimeEntityType.FindProperty("ValueTypeIList")!;
            var valueTypeList = runtimeEntityType.FindProperty("ValueTypeList")!;
            var owned = runtimeEntityType.FindNavigation("Owned")!;
            var dependent = runtimeEntityType.FindNavigation("Dependent")!;
            var manyOwned = runtimeEntityType.FindNavigation("ManyOwned")!;
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity8 = ((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long?, Guid, string, CompiledModelTestBase.AnEnum, CompiledModelTestBase.AnEnum?, CompiledModelTestBase.AFlagsEnum, CompiledModelTestBase.AFlagsEnum, IPAddress[], IEnumerable<string>, IList<string>, List<IPAddress>, DateTime[], IEnumerable<byte>, IList<byte>, List<short>>((source.GetCurrentValue<long?>(id) == null ? null : ((ValueComparer<long?>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<long?>(id))), ((ValueComparer<Guid>)(((IProperty)alternateId).GetValueComparer())).Snapshot(source.GetCurrentValue<Guid>(alternateId)), (source.GetCurrentValue<string>(discriminator) == null ? null : ((ValueComparer<string>)(((IProperty)discriminator).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(discriminator))), ((ValueComparer<CompiledModelTestBase.AnEnum>)(((IProperty)enum1).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum>(enum1)), (source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum2) == null ? null : ((ValueComparer<CompiledModelTestBase.AnEnum?>)(((IProperty)enum2).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum2))), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum1).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum1)), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum2).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum2)), (((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray))) == null ? null : ((IPAddress[])(((ValueComparer<object>)(((IProperty)refTypeArray).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray))))))), (((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable))) == null ? null : ((IEnumerable<string>)(((ValueComparer<object>)(((IProperty)refTypeEnumerable).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable))))))), (((object)(source.GetCurrentValue<IList<string>>(refTypeIList))) == null ? null : ((IList<string>)(((ValueComparer<object>)(((IProperty)refTypeIList).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IList<string>>(refTypeIList))))))), (((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList))) == null ? null : ((List<IPAddress>)(((ValueComparer<object>)(((IProperty)refTypeList).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList))))))), (((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray))) == null ? null : ((DateTime[])(((ValueComparer<IEnumerable<DateTime>>)(((IProperty)valueTypeArray).GetValueComparer())).Snapshot(((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray))))))), (source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable) == null ? null : ((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeEnumerable).GetValueComparer())).Snapshot(source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable))), (((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList))) == null ? null : ((IList<byte>)(((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeIList).GetValueComparer())).Snapshot(((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList))))))), (((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList))) == null ? null : ((List<short>)(((ValueComparer<IEnumerable<short>>)(((IProperty)valueTypeList).GetValueComparer())).Snapshot(((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList))))))))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => Snapshot.Empty);
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => Snapshot.Empty);
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => ((ISnapshot)(new Snapshot<string>((source.ContainsKey("Discriminator") ? ((string)(source["Discriminator"])) : null)))));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<string>(default(string)))));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity8 = ((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long?, Guid, object, object, object, object, object>((source.GetCurrentValue<long?>(id) == null ? null : ((ValueComparer<long?>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<long?>(id))), ((ValueComparer<Guid>)(((IProperty)alternateId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<Guid>(alternateId)), PrincipalBaseUnsafeAccessors._ownedField(entity8), null, PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(entity8), SnapshotFactoryFactory.SnapshotCollection(PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.ManyOwned(entity8)), null)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 15,
                navigationCount: 5,
                complexPropertyCount: 0,
                originalValueCount: 15,
                shadowCount: 1,
                relationshipCount: 7,
                storeGeneratedCount: 0);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBase");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
