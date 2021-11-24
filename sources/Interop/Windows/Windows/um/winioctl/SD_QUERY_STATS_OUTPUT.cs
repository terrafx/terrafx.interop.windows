// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct SD_QUERY_STATS_OUTPUT
{
    [NativeTypeName("DWORDLONG")]
    public ulong SdsStreamSize;

    [NativeTypeName("DWORDLONG")]
    public ulong SdsAllocationSize;

    [NativeTypeName("DWORDLONG")]
    public ulong SiiStreamSize;

    [NativeTypeName("DWORDLONG")]
    public ulong SiiAllocationSize;

    [NativeTypeName("DWORDLONG")]
    public ulong SdhStreamSize;

    [NativeTypeName("DWORDLONG")]
    public ulong SdhAllocationSize;

    [NativeTypeName("DWORDLONG")]
    public ulong NumSDTotal;

    [NativeTypeName("DWORDLONG")]
    public ulong NumSDUnused;
}
