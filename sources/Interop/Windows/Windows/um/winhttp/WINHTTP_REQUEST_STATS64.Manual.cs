// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WINHTTP_REQUEST_STATS64
{
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    [NativeTypeName("ULONG")]
    public uint ulIndex;

    [NativeTypeName("ULONG")]
    public uint cStats;

    [NativeTypeName("ULONGLONG[32]")]
    public _rgullStats_e__FixedBuffer rgullStats;

    [InlineArray(32)]
    public partial struct _rgullStats_e__FixedBuffer
    {
        public ulong e0;
    }
}
