// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct HIDD_CONFIGURATION
{
    [NativeTypeName("PVOID")]
    public void* cookie;

    [NativeTypeName("ULONG")]
    public uint size;

    [NativeTypeName("ULONG")]
    public uint RingBufferSize;
}
