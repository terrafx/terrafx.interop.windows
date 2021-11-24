// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct RESTOREPOINTINFOEX
{
    public FILETIME ftCreation;

    [NativeTypeName("DWORD")]
    public uint dwEventType;

    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;

    [NativeTypeName("DWORD")]
    public uint dwRPNum;

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort szDescription[256];
}
