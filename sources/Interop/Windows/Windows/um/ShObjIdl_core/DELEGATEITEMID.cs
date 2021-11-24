// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DELEGATEITEMID
{
    [NativeTypeName("WORD")]
    public ushort cbSize;

    [NativeTypeName("WORD")]
    public ushort wOuter;

    [NativeTypeName("WORD")]
    public ushort cbInner;

    [NativeTypeName("BYTE [1]")]
    public fixed byte rgb[1];
}
