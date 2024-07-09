// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public partial class DbFunctionContextModel
    {
        private DbFunctionContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 2, typeConfigurationCount: 1)
        {
        }

        partial void Initialize()
        {
            var data = DataEntityType.Create(this);
            var @object = ObjectEntityType.Create(this);

            DataEntityType.CreateAnnotations(data);
            ObjectEntityType.CreateAnnotations(@object);

            var type = this.AddTypeMappingConfiguration(
                typeof(string),
                maxLength: 256);
            type.AddAnnotation("Relational:IsFixedLength", true);

            var functions = new Dictionary<string, IDbFunction>();
            var getBlobs = new RuntimeDbFunction(
                "GetBlobs()",
                this,
                typeof(IQueryable<object>),
                "GetBlobs",
                schema: "dbo");

            functions["GetBlobs()"] = getBlobs;

            var getCount = new RuntimeDbFunction(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetCount(System.Guid?,string)",
                this,
                typeof(int),
                "CustomerOrderCount",
                schema: "dbf",
                storeType: "int",
                methodInfo: typeof(CompiledModelRelationalTestBase.DbFunctionContext).GetMethod(
                    "GetCount",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly,
                    null,
                    new Type[] { typeof(Guid?), typeof(string) },
                    null),
                scalar: true);

            var id = getCount.AddParameter(
                "id",
                typeof(Guid?),
                true,
                "uniqueidentifier");
            id.TypeMapping = GuidTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid>(
                    bool (Guid v1, Guid v2) => v1 == v2,
                    int (Guid v) => ((object)v).GetHashCode(),
                    Guid (Guid v) => v),
                keyComparer: new ValueComparer<Guid>(
                    bool (Guid v1, Guid v2) => v1 == v2,
                    int (Guid v) => ((object)v).GetHashCode(),
                    Guid (Guid v) => v),
                providerValueComparer: new ValueComparer<Guid>(
                    bool (Guid v1, Guid v2) => v1 == v2,
                    int (Guid v) => ((object)v).GetHashCode(),
                    Guid (Guid v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "uniqueidentifier"));
            id.AddAnnotation("MyAnnotation", new[] { 1L });

            var condition = getCount.AddParameter(
                "condition",
                typeof(string),
                false,
                "nchar(256)");
            condition.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
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
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nchar(256)",
                    size: 256,
                    unicode: true,
                    fixedLength: true,
                    dbType: System.Data.DbType.StringFixedLength));

            getCount.TypeMapping = IntTypeMapping.Default.Clone(
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
            functions["Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetCount(System.Guid?,string)"] = getCount;

            var getData = new RuntimeDbFunction(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData()",
                this,
                typeof(IQueryable<CompiledModelTestBase.Data>),
                "GetAllData",
                schema: "dbo",
                methodInfo: typeof(CompiledModelRelationalTestBase.DbFunctionContext).GetMethod(
                    "GetData",
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly,
                    null,
                    new Type[] {  },
                    null));

            functions["Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData()"] = getData;

            var getData0 = new RuntimeDbFunction(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData(int)",
                this,
                typeof(IQueryable<CompiledModelTestBase.Data>),
                "GetData",
                schema: "dbo",
                methodInfo: typeof(CompiledModelRelationalTestBase.DbFunctionContext).GetMethod(
                    "GetData",
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly,
                    null,
                    new Type[] { typeof(int) },
                    null));

            var id0 = getData0.AddParameter(
                "id",
                typeof(int),
                false,
                "int");
            id0.TypeMapping = IntTypeMapping.Default.Clone(
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

            functions["Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData(int)"] = getData0;

            var isDateStatic = new RuntimeDbFunction(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.IsDateStatic(string)",
                this,
                typeof(bool),
                "IsDate",
                storeType: "bit",
                methodInfo: typeof(CompiledModelRelationalTestBase.DbFunctionContext).GetMethod(
                    "IsDateStatic",
                    BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly,
                    null,
                    new Type[] { typeof(string) },
                    null),
                scalar: true,
                nullable: true,
                builtIn: true);

            var date = isDateStatic.AddParameter(
                "date",
                typeof(string),
                false,
                "nchar(256)");
            date.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
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
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nchar(256)",
                    size: 256,
                    unicode: true,
                    fixedLength: true,
                    dbType: System.Data.DbType.StringFixedLength));

            isDateStatic.TypeMapping = SqlServerBoolTypeMapping.Default.Clone(
                comparer: new ValueComparer<bool>(
                    bool (bool v1, bool v2) => v1 == v2,
                    int (bool v) => ((object)v).GetHashCode(),
                    bool (bool v) => v),
                keyComparer: new ValueComparer<bool>(
                    bool (bool v1, bool v2) => v1 == v2,
                    int (bool v) => ((object)v).GetHashCode(),
                    bool (bool v) => v),
                providerValueComparer: new ValueComparer<bool>(
                    bool (bool v1, bool v2) => v1 == v2,
                    int (bool v) => ((object)v).GetHashCode(),
                    bool (bool v) => v));
            isDateStatic.AddAnnotation("MyGuid", new Guid("00000000-0000-0000-0000-000000000000"));
            functions["Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.IsDateStatic(string)"] = isDateStatic;

            AddAnnotation("Relational:DbFunctions", functions);
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            AddRuntimeAnnotation("Relational:RelationalModelFactory", () => CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var data = FindEntityType("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            data.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase = new TableBase("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", null, relationalModel);
            var blobColumnBase = new ColumnBase<ColumnMappingBase>("Blob", "varbinary(max)", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase)
            {
                IsNullable = true
            };
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.Columns.Add("Blob", blobColumnBase);
            relationalModel.DefaultTables.Add("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase = new TableMappingBase<ColumnMappingBase>(data, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase, null);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.AddTypeMapping(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase, false);
            defaultTableMappings.Add(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)blobColumnBase, data.FindProperty("Blob")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);

            var functionMappings = new List<FunctionMapping>();
            data.SetRuntimeAnnotation("Relational:FunctionMappings", functionMappings);
            var getAllData = (IRuntimeDbFunction)this.FindDbFunction("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData()")!;
            var getAllDataFunction = new StoreFunction(getAllData, relationalModel);
            var blobFunctionColumn = new FunctionColumn("Blob", "varbinary(max)", getAllDataFunction)
            {
                IsNullable = true
            };
            getAllDataFunction.Columns.Add("Blob", blobFunctionColumn);
            relationalModel.Functions.Add(
                ("GetAllData", "dbo", new string[0]),
                getAllDataFunction);
            var getAllDataFunctionMapping = new FunctionMapping(data, getAllDataFunction, getAllData, null);
            getAllDataFunction.AddTypeMapping(getAllDataFunctionMapping, false);
            functionMappings.Add(getAllDataFunctionMapping);
            getAllDataFunctionMapping.IsDefaultFunctionMapping = true;
            RelationalModel.CreateFunctionColumnMapping(blobFunctionColumn, data.FindProperty("Blob")!, getAllDataFunctionMapping);
            var getData = (IRuntimeDbFunction)this.FindDbFunction("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetData(int)")!;
            var getDataFunction = new StoreFunction(getData, relationalModel);
            var idFunctionParameter = getDataFunction.FindParameter("id")!;
            var blobFunctionColumn0 = new FunctionColumn("Blob", "varbinary(max)", getDataFunction)
            {
                IsNullable = true
            };
            getDataFunction.Columns.Add("Blob", blobFunctionColumn0);
            relationalModel.Functions.Add(
                ("GetData", "dbo", new[] { "int" }),
                getDataFunction);
            var getDataFunctionMapping = new FunctionMapping(data, getDataFunction, getData, null);
            getDataFunction.AddTypeMapping(getDataFunctionMapping, false);
            functionMappings.Add(getDataFunctionMapping);
            RelationalModel.CreateFunctionColumnMapping(blobFunctionColumn0, data.FindProperty("Blob")!, getDataFunctionMapping);

            var @object = FindEntityType("object")!;

            var defaultTableMappings0 = new List<TableMappingBase<ColumnMappingBase>>();
            @object.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings0);
            var objectTableBase = new TableBase("object", null, relationalModel);
            relationalModel.DefaultTables.Add("object", objectTableBase);
            var objectMappingBase = new TableMappingBase<ColumnMappingBase>(@object, objectTableBase, null);
            objectTableBase.AddTypeMapping(objectMappingBase, false);
            defaultTableMappings0.Add(objectMappingBase);

            var functionMappings0 = new List<FunctionMapping>();
            @object.SetRuntimeAnnotation("Relational:FunctionMappings", functionMappings0);
            var getBlobs = (IRuntimeDbFunction)this.FindDbFunction("GetBlobs()")!;
            var getBlobsFunction = new StoreFunction(getBlobs, relationalModel);
            relationalModel.Functions.Add(
                ("GetBlobs", "dbo", new string[0]),
                getBlobsFunction);
            var getBlobsFunctionMapping = new FunctionMapping(@object, getBlobsFunction, getBlobs, null);
            getBlobsFunction.AddTypeMapping(getBlobsFunctionMapping, false);
            functionMappings0.Add(getBlobsFunctionMapping);
            getBlobsFunctionMapping.IsDefaultFunctionMapping = true;
            var customerOrderCount = (IRuntimeDbFunction)this.FindDbFunction("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.GetCount(System.Guid?,string)")!;
            var customerOrderCountFunction = new StoreFunction(customerOrderCount, relationalModel);
            var idFunctionParameter0 = customerOrderCountFunction.FindParameter("id")!;
            var conditionFunctionParameter = customerOrderCountFunction.FindParameter("condition")!;
            relationalModel.Functions.Add(
                ("CustomerOrderCount", "dbf", new[] { "uniqueidentifier", "nchar(256)" }),
                customerOrderCountFunction);
            var isDate = (IRuntimeDbFunction)this.FindDbFunction("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelRelationalTestBase+DbFunctionContext.IsDateStatic(string)")!;
            var isDateFunction = new StoreFunction(isDate, relationalModel);
            var dateFunctionParameter = isDateFunction.FindParameter("date")!;
            relationalModel.Functions.Add(
                ("IsDate", null, new[] { "nchar(256)" }),
                isDateFunction);
            return relationalModel.MakeReadOnly();
        }
    }
}
