// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHChangeUpdateImageIDList
{
    public ushort cb;

    public int iIconIndex;

    public int iCurIndex;

    public uint uFlags;

    [NativeTypeName("DWORD")]
    public uint dwProcessID;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort szName[260];

    public ushort cbZero;
}
