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
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
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
                propertyCount: 1);

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
                byte[] (InternalEntityEntry entry) => entry.ReadOriginalValue<byte[]>(blob, 0),
                byte[] (InternalEntityEntry entry) => entry.GetCurrentValue<byte[]>(blob),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            blob.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            blob.TypeMapping = SqliteByteArrayTypeMapping.Default.Clone(
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
                    byte[] (byte[] source) => source.ToArray()));

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var blob = runtimeEntityType.FindProperty("Blob")!;
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.Data)(source.Entity));
                    return ((ISnapshot)(new Snapshot<byte[]>((source.GetCurrentValue<byte[]>(blob) == null ? null : ((ValueComparer<byte[]>)(((IProperty)blob).GetValueComparer())).Snapshot(source.GetCurrentValue<byte[]>(blob))))));
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
                ISnapshot (InternalEntityEntry source) => Snapshot.Empty);
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 1,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 1,
                shadowCount: 0,
                relationshipCount: 0,
                storeGeneratedCount: 0);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData()");
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
