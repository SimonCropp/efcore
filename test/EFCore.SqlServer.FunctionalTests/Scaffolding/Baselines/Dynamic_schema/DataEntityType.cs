// <auto-generated />
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DataEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data",
                typeof(CompiledModelTestBase.Data),
                baseEntityType,
                propertyCount: 2,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetAccessors(
                int (InternalEntityEntry entry) => (entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : (entry.FlaggedAsTemporary(0) && entry.ReadShadowValue<int>(0) == 0 ? entry.ReadTemporaryValue<int>(0) : entry.ReadShadowValue<int>(0))),
                int (InternalEntityEntry entry) => entry.ReadShadowValue<int>(0),
                int (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                int (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: 0,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            id.TypeMapping = IntTypeMapping.Default.Clone(
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
                    int (int v) => v));
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var blob = runtimeEntityType.AddProperty(
                "Blob",
                typeof(byte[]),
                propertyInfo: typeof(CompiledModelTestBase.Data).GetProperty("Blob", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.Data).GetField("<Blob>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            blob.SetGetter(
                byte[] (CompiledModelTestBase.Data entity) => DataUnsafeAccessors.Blob(entity),
                bool (CompiledModelTestBase.Data entity) => DataUnsafeAccessors.Blob(entity) == null,
                byte[] (CompiledModelTestBase.Data instance) => DataUnsafeAccessors.Blob(instance),
                bool (CompiledModelTestBase.Data instance) => DataUnsafeAccessors.Blob(instance) == null);
            blob.SetSetter(
                (CompiledModelTestBase.Data entity, byte[] value) => DataUnsafeAccessors.Blob(entity) = value);
            blob.SetMaterializationSetter(
                (CompiledModelTestBase.Data entity, byte[] value) => DataUnsafeAccessors.Blob(entity) = value);
            blob.SetAccessors(
                byte[] (InternalEntityEntry entry) => DataUnsafeAccessors.Blob(((CompiledModelTestBase.Data)(entry.Entity))),
                byte[] (InternalEntityEntry entry) => DataUnsafeAccessors.Blob(((CompiledModelTestBase.Data)(entry.Entity))),
                byte[] (InternalEntityEntry entry) => entry.ReadOriginalValue<byte[]>(blob, 1),
                byte[] (InternalEntityEntry entry) => entry.GetCurrentValue<byte[]>(blob),
                object (ValueBuffer valueBuffer) => valueBuffer[1]);
            blob.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            blob.TypeMapping = SqlServerByteArrayTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte[]>(
                    bool (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals(((object)(v1)), ((object)(v2))),
                    int (byte[] v) => ((object)v).GetHashCode(),
                    byte[] (byte[] v) => v),
                keyComparer: new ValueComparer<byte[]>(
                    bool (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals(((object)(v1)), ((object)(v2))),
                    int (byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode(((object)(v))),
                    byte[] (byte[] source) => source.ToArray()),
                providerValueComparer: new ValueComparer<byte[]>(
                    bool (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals(((object)(v1)), ((object)(v2))),
                    int (byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode(((object)(v))),
                    byte[] (byte[] source) => source.ToArray()),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "varbinary(max)"),
                storeTypePostfix: StoreTypePostfix.None);
            blob.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var blob = runtimeEntityType.FindProperty("Blob")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.Data)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int, byte[]>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<int>(id)), (source.GetCurrentValue<byte[]>(blob) == null ? null : ((ValueComparer<byte[]>)(((IProperty)blob).GetValueComparer())).Snapshot(source.GetCurrentValue<byte[]>(blob))))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(default(int))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => ((ISnapshot)(new Snapshot<int>(default(int)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => ((ISnapshot)(new Snapshot<int>((source.ContainsKey("Id") ? ((int)(source["Id"])) : 0)))));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<int>(default(int)))));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.Data)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<int>(id)))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 1,
                relationshipCount: 1,
                storeGeneratedCount: 1);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Data");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
