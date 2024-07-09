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
    public partial class DependentDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>",
                typeof(CompiledModelTestBase.DependentDerived<int>),
                baseEntityType,
                propertyCount: 2,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelTestBase.AbstractBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<int>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                int (CompiledModelTestBase.DependentDerived<int> entity) => DependentBaseUnsafeAccessors<int>.Id(entity),
                bool (CompiledModelTestBase.DependentDerived<int> entity) => DependentBaseUnsafeAccessors<int>.Id(entity) == 0,
                int (CompiledModelTestBase.DependentDerived<int> instance) => DependentBaseUnsafeAccessors<int>.Id(instance),
                bool (CompiledModelTestBase.DependentDerived<int> instance) => DependentBaseUnsafeAccessors<int>.Id(instance) == 0);
            id.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => DependentBaseUnsafeAccessors<int>.Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => DependentBaseUnsafeAccessors<int>.Id(entity) = value);
            id.SetAccessors(
                int (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<int>.Id(((CompiledModelTestBase.DependentDerived<int>)(entry.Entity))),
                int (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<int>.Id(((CompiledModelTestBase.DependentDerived<int>)(entry.Entity))),
                int (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                int (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: -1);
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

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            data.SetGetter(
                string (CompiledModelTestBase.DependentDerived<int> entity) => DependentDerivedUnsafeAccessors<int>.Data(entity),
                bool (CompiledModelTestBase.DependentDerived<int> entity) => DependentDerivedUnsafeAccessors<int>.Data(entity) == null,
                string (CompiledModelTestBase.DependentDerived<int> instance) => DependentDerivedUnsafeAccessors<int>.Data(instance),
                bool (CompiledModelTestBase.DependentDerived<int> instance) => DependentDerivedUnsafeAccessors<int>.Data(instance) == null);
            data.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => DependentDerivedUnsafeAccessors<int>.Data(entity) = value);
            data.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => DependentDerivedUnsafeAccessors<int>.Data(entity) = value);
            data.SetAccessors(
                string (InternalEntityEntry entry) => DependentDerivedUnsafeAccessors<int>.Data(((CompiledModelTestBase.DependentDerived<int>)(entry.Entity))),
                string (InternalEntityEntry entry) => DependentDerivedUnsafeAccessors<int>.Data(((CompiledModelTestBase.DependentDerived<int>)(entry.Entity))),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(data, 1),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(data),
                object (ValueBuffer valueBuffer) => valueBuffer[1]);
            data.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            data.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                keyComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var data = runtimeEntityType.FindProperty("Data")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.DependentDerived<int>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int, string>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<int>(id)), (source.GetCurrentValue<string>(data) == null ? null : ((ValueComparer<string>)(((IProperty)data).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(data))))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => Snapshot.Empty);
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => Snapshot.Empty);
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.DependentDerived<int>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<int>(id)))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 0,
                relationshipCount: 1,
                storeGeneratedCount: 0);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
