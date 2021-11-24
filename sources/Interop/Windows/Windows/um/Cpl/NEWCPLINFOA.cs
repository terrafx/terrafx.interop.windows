// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct NEWCPLINFOA
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwHelpContext;

    [NativeTypeName("LONG_PTR")]
    public nint lData;

    public HICON hIcon;

    [NativeTypeName("CHAR [32]")]
    public fixed sbyte szName[32];

    [NativeTypeName("CHAR [64]")]
    public fixed sbyte szInfo[64];

    [NativeTypeName("CHAR [128]")]
    public fixed sbyte szHelpFile[128];
}
