// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class LazyProxiesEntity2EntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+LazyProxiesEntity2",
                typeof(CompiledModelInMemoryTest.LazyProxiesEntity2),
                baseEntityType,
                propertyCount: 1,
                navigationCount: 1,
                servicePropertyCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyProxiesEntity2).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyProxiesEntity2).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                int (CompiledModelInMemoryTest.LazyProxiesEntity2 entity) => LazyProxiesEntity2UnsafeAccessors.Id(entity),
                bool (CompiledModelInMemoryTest.LazyProxiesEntity2 entity) => LazyProxiesEntity2UnsafeAccessors.Id(entity) == 0,
                int (CompiledModelInMemoryTest.LazyProxiesEntity2 instance) => LazyProxiesEntity2UnsafeAccessors.Id(instance),
                bool (CompiledModelInMemoryTest.LazyProxiesEntity2 instance) => LazyProxiesEntity2UnsafeAccessors.Id(instance) == 0);
            id.SetSetter(
                (CompiledModelInMemoryTest.LazyProxiesEntity2 entity, int value) => LazyProxiesEntity2UnsafeAccessors.Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyProxiesEntity2 entity, int value) => LazyProxiesEntity2UnsafeAccessors.Id(entity) = value);
            id.SetAccessors(
                int (InternalEntityEntry entry) => (entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : (entry.FlaggedAsTemporary(0) && LazyProxiesEntity2UnsafeAccessors.Id(((CompiledModelInMemoryTest.LazyProxiesEntity2)(entry.Entity))) == 0 ? entry.ReadTemporaryValue<int>(0) : LazyProxiesEntity2UnsafeAccessors.Id(((CompiledModelInMemoryTest.LazyProxiesEntity2)(entry.Entity))))),
                int (InternalEntityEntry entry) => LazyProxiesEntity2UnsafeAccessors.Id(((CompiledModelInMemoryTest.LazyProxiesEntity2)(entry.Entity))),
                int (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                int (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            id.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                keyComparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));

            var loader = runtimeEntityType.AddServiceProperty(
                "Loader",
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyProxiesEntity2).GetProperty("Loader", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(ILazyLoader));
            loader.SetPropertyIndexes(
                index: -1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            var collectionNavigation = runtimeEntityType.FindNavigation("CollectionNavigation")!;
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelInMemoryTest.LazyProxiesEntity2)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<int>(id)))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(default(int))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => ((ISnapshot)(new Snapshot<int>(default(int)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelInMemoryTest.LazyProxiesEntity2)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int, object>(((ValueComparer<int>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<int>(id)), SnapshotFactoryFactory.SnapshotCollection(LazyProxiesEntity2UnsafeAccessors.CollectionNavigation(entity)))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 1,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 1,
                shadowCount: 0,
                relationshipCount: 2,
                storeGeneratedCount: 1);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
