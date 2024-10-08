// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.BulkUpdates;

public abstract class TPHInheritanceBulkUpdatesTestBase<TFixture> : InheritanceBulkUpdatesTestBase<TFixture>
    where TFixture : InheritanceBulkUpdatesFixtureBase, new()
{
    protected TPHInheritanceBulkUpdatesTestBase(TFixture fixture)
        : base(fixture)
    {
    }
}
