// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct WINHTTP_REQUEST_TIMES64
{
    [NativeTypeName("ULONG")]
    public uint cTimes;

    [NativeTypeName("ULONGLONG [64]")]
    public fixed ulong rgullTimes[64];
}
