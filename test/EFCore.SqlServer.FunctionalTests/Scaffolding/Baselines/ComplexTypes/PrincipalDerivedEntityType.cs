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
                propertyCount: 0);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id");
            var discriminator = runtimeEntityType.FindProperty("Discriminator");
            var enum1 = runtimeEntityType.FindProperty("Enum1");
            var enum2 = runtimeEntityType.FindProperty("Enum2");
            var flagsEnum1 = runtimeEntityType.FindProperty("FlagsEnum1");
            var flagsEnum2 = runtimeEntityType.FindProperty("FlagsEnum2");
            var principalBaseId = runtimeEntityType.FindProperty("PrincipalBaseId");
            var refTypeArray = runtimeEntityType.FindProperty("RefTypeArray");
            var refTypeEnumerable = runtimeEntityType.FindProperty("RefTypeEnumerable");
            var refTypeIList = runtimeEntityType.FindProperty("RefTypeIList");
            var refTypeList = runtimeEntityType.FindProperty("RefTypeList");
            var valueTypeArray = runtimeEntityType.FindProperty("ValueTypeArray");
            var valueTypeEnumerable = runtimeEntityType.FindProperty("ValueTypeEnumerable");
            var valueTypeIList = runtimeEntityType.FindProperty("ValueTypeIList");
            var valueTypeList = runtimeEntityType.FindProperty("ValueTypeList");
            var owned = runtimeEntityType.FindComplexProperty("Owned");
            var ownedType = owned.ComplexType;
            var details = ownedType.FindProperty("Details");
            var number = ownedType.FindProperty("Number");
            var refTypeArray0 = ownedType.FindProperty("RefTypeArray");
            var refTypeEnumerable0 = ownedType.FindProperty("RefTypeEnumerable");
            var refTypeIList0 = ownedType.FindProperty("RefTypeIList");
            var refTypeList0 = ownedType.FindProperty("RefTypeList");
            var valueTypeArray0 = ownedType.FindProperty("ValueTypeArray");
            var valueTypeEnumerable0 = ownedType.FindProperty("ValueTypeEnumerable");
            var valueTypeIList0 = ownedType.FindProperty("ValueTypeIList");
            var valueTypeList0 = ownedType.FindProperty("ValueTypeList");
            var principal = ownedType.FindComplexProperty("Principal");
            var principalBase = principal.ComplexType;
            var alternateId = principalBase.FindProperty("AlternateId");
            var enum10 = principalBase.FindProperty("Enum1");
            var enum20 = principalBase.FindProperty("Enum2");
            var flagsEnum10 = principalBase.FindProperty("FlagsEnum1");
            var flagsEnum20 = principalBase.FindProperty("FlagsEnum2");
            var id0 = principalBase.FindProperty("Id");
            var refTypeArray1 = principalBase.FindProperty("RefTypeArray");
            var refTypeEnumerable1 = principalBase.FindProperty("RefTypeEnumerable");
            var refTypeIList1 = principalBase.FindProperty("RefTypeIList");
            var refTypeList1 = principalBase.FindProperty("RefTypeList");
            var valueTypeArray1 = principalBase.FindProperty("ValueTypeArray");
            var valueTypeEnumerable1 = principalBase.FindProperty("ValueTypeEnumerable");
            var valueTypeIList1 = principalBase.FindProperty("ValueTypeIList");
            var valueTypeList1 = principalBase.FindProperty("ValueTypeList");
            var deriveds = runtimeEntityType.FindNavigation("Deriveds");
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity1 = ((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(source.Entity));
                    var liftedArg0 = ((ISnapshot)(new Snapshot<long?, string, CompiledModelTestBase.AnEnum, CompiledModelTestBase.AnEnum?, CompiledModelTestBase.AFlagsEnum, CompiledModelTestBase.AFlagsEnum, long?, IPAddress[], IEnumerable<string>, IList<string>, List<IPAddress>, DateTime[], IEnumerable<byte>, IList<byte>, List<short>, string, int, IPAddress[], IEnumerable<string>, IList<string>, List<IPAddress>, DateTime[], IEnumerable<byte>, IList<byte>, List<short>, Guid, CompiledModelTestBase.AnEnum, CompiledModelTestBase.AnEnum?, CompiledModelTestBase.AFlagsEnum, CompiledModelTestBase.AFlagsEnum>((source.GetCurrentValue<long?>(id) == null ? null : ((ValueComparer<long?>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<long?>(id))), (source.GetCurrentValue<string>(discriminator) == null ? null : ((ValueComparer<string>)(((IProperty)discriminator).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(discriminator))), ((ValueComparer<CompiledModelTestBase.AnEnum>)(((IProperty)enum1).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum>(enum1)), (source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum2) == null ? null : ((ValueComparer<CompiledModelTestBase.AnEnum?>)(((IProperty)enum2).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum2))), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum1).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum1)), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum2).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum2)), (source.GetCurrentValue<long?>(principalBaseId) == null ? null : ((ValueComparer<long?>)(((IProperty)principalBaseId).GetValueComparer())).Snapshot(source.GetCurrentValue<long?>(principalBaseId))), (((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray))) == null ? null : ((IPAddress[])(((ValueComparer<object>)(((IProperty)refTypeArray).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray))))))), (((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable))) == null ? null : ((IEnumerable<string>)(((ValueComparer<object>)(((IProperty)refTypeEnumerable).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable))))))), (((object)(source.GetCurrentValue<IList<string>>(refTypeIList))) == null ? null : ((IList<string>)(((ValueComparer<object>)(((IProperty)refTypeIList).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IList<string>>(refTypeIList))))))), (((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList))) == null ? null : ((List<IPAddress>)(((ValueComparer<object>)(((IProperty)refTypeList).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList))))))), (((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray))) == null ? null : ((DateTime[])(((ValueComparer<IEnumerable<DateTime>>)(((IProperty)valueTypeArray).GetValueComparer())).Snapshot(((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray))))))), (source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable) == null ? null : ((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeEnumerable).GetValueComparer())).Snapshot(source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable))), (((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList))) == null ? null : ((IList<byte>)(((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeIList).GetValueComparer())).Snapshot(((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList))))))), (((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList))) == null ? null : ((List<short>)(((ValueComparer<IEnumerable<short>>)(((IProperty)valueTypeList).GetValueComparer())).Snapshot(((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList))))))), (source.GetCurrentValue<string>(details) == null ? null : ((ValueComparer<string>)(((IProperty)details).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(details))), ((ValueComparer<int>)(((IProperty)number).GetValueComparer())).Snapshot(source.GetCurrentValue<int>(number)), (((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray0))) == null ? null : ((IPAddress[])(((ValueComparer<object>)(((IProperty)refTypeArray0).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray0))))))), (((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable0))) == null ? null : ((IEnumerable<string>)(((ValueComparer<object>)(((IProperty)refTypeEnumerable0).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable0))))))), (((object)(source.GetCurrentValue<IList<string>>(refTypeIList0))) == null ? null : ((IList<string>)(((ValueComparer<object>)(((IProperty)refTypeIList0).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IList<string>>(refTypeIList0))))))), (((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList0))) == null ? null : ((List<IPAddress>)(((ValueComparer<object>)(((IProperty)refTypeList0).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList0))))))), (((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray0))) == null ? null : ((DateTime[])(((ValueComparer<IEnumerable<DateTime>>)(((IProperty)valueTypeArray0).GetValueComparer())).Snapshot(((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray0))))))), (source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable0) == null ? null : ((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeEnumerable0).GetValueComparer())).Snapshot(source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable0))), (((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList0))) == null ? null : ((IList<byte>)(((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeIList0).GetValueComparer())).Snapshot(((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList0))))))), (((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList0))) == null ? null : ((List<short>)(((ValueComparer<IEnumerable<short>>)(((IProperty)valueTypeList0).GetValueComparer())).Snapshot(((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList0))))))), ((ValueComparer<Guid>)(((IProperty)alternateId).GetValueComparer())).Snapshot(source.GetCurrentValue<Guid>(alternateId)), ((ValueComparer<CompiledModelTestBase.AnEnum>)(((IProperty)enum10).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum>(enum10)), (source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum20) == null ? null : ((ValueComparer<CompiledModelTestBase.AnEnum?>)(((IProperty)enum20).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum?>(enum20))), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum10).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum10)), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)(((IProperty)flagsEnum20).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum20)))));
                    var entity2 = ((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(source.Entity));
                    return ((ISnapshot)(new MultiSnapshot(new ISnapshot[] { liftedArg0, ((ISnapshot)(new Snapshot<long?, IPAddress[], IEnumerable<string>, IList<string>, List<IPAddress>, DateTime[], IEnumerable<byte>, IList<byte>, List<short>>((source.GetCurrentValue<long?>(id0) == null ? null : ((ValueComparer<long?>)(((IProperty)id0).GetValueComparer())).Snapshot(source.GetCurrentValue<long?>(id0))), (((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray1))) == null ? null : ((IPAddress[])(((ValueComparer<object>)(((IProperty)refTypeArray1).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IPAddress[]>(refTypeArray1))))))), (((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable1))) == null ? null : ((IEnumerable<string>)(((ValueComparer<object>)(((IProperty)refTypeEnumerable1).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable1))))))), (((object)(source.GetCurrentValue<IList<string>>(refTypeIList1))) == null ? null : ((IList<string>)(((ValueComparer<object>)(((IProperty)refTypeIList1).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<IList<string>>(refTypeIList1))))))), (((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList1))) == null ? null : ((List<IPAddress>)(((ValueComparer<object>)(((IProperty)refTypeList1).GetValueComparer())).Snapshot(((object)(source.GetCurrentValue<List<IPAddress>>(refTypeList1))))))), (((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray1))) == null ? null : ((DateTime[])(((ValueComparer<IEnumerable<DateTime>>)(((IProperty)valueTypeArray1).GetValueComparer())).Snapshot(((IEnumerable<DateTime>)(source.GetCurrentValue<DateTime[]>(valueTypeArray1))))))), (source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable1) == null ? null : ((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeEnumerable1).GetValueComparer())).Snapshot(source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable1))), (((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList1))) == null ? null : ((IList<byte>)(((ValueComparer<IEnumerable<byte>>)(((IProperty)valueTypeIList1).GetValueComparer())).Snapshot(((IEnumerable<byte>)(source.GetCurrentValue<IList<byte>>(valueTypeIList1))))))), (((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList1))) == null ? null : ((List<short>)(((ValueComparer<IEnumerable<short>>)(((IProperty)valueTypeList1).GetValueComparer())).Snapshot(((IEnumerable<short>)(source.GetCurrentValue<List<short>>(valueTypeList1)))))))))) })));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<long?, long?, string>((default(long? ) == null ? null : ((ValueComparer<long?>)(((IProperty)id).GetValueComparer())).Snapshot(default(long? ))), (default(long? ) == null ? null : ((ValueComparer<long?>)(((IProperty)principalBaseId).GetValueComparer())).Snapshot(default(long? ))), (default(string) == null ? null : ((ValueComparer<string>)(((IProperty)details).GetValueComparer())).Snapshot(default(string)))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => ((ISnapshot)(new Snapshot<long?, long?, string>(default(long? ), default(long? ), default(string)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => ((ISnapshot)(new Snapshot<string, long?>((source.ContainsKey("Discriminator") ? ((string)(source["Discriminator"])) : null), (source.ContainsKey("PrincipalBaseId") ? ((long? )(source["PrincipalBaseId"])) : null)))));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<string, long?>(default(string), default(long? )))));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity3 = ((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long?, long?, object>((source.GetCurrentValue<long?>(id) == null ? null : ((ValueComparer<long?>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<long?>(id))), (source.GetCurrentValue<long?>(principalBaseId) == null ? null : ((ValueComparer<long?>)(((IProperty)principalBaseId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<long?>(principalBaseId))), SnapshotFactoryFactory.SnapshotCollection(PrincipalBaseUnsafeAccessors.Deriveds(entity3)))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 39,
                navigationCount: 1,
                complexPropertyCount: 2,
                originalValueCount: 39,
                shadowCount: 2,
                relationshipCount: 3,
                storeGeneratedCount: 3);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", "select * from PrincipalBase");
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBase");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
