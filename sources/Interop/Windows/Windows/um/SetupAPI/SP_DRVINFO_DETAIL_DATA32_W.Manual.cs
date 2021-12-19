// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_DRVINFO_DETAIL_DATA32_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public FILETIME InfDate;

    [NativeTypeName("DWORD")]
    public uint CompatIDsOffset;

    [NativeTypeName("DWORD")]
    public uint CompatIDsLength;

    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort SectionName[256];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort InfFileName[260];

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort DrvDescription[256];

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort HardwareID[1];
}
