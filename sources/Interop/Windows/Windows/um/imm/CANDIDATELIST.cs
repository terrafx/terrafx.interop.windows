// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CANDIDATELIST
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwStyle;

    [NativeTypeName("DWORD")]
    public uint dwCount;

    [NativeTypeName("DWORD")]
    public uint dwSelection;

    [NativeTypeName("DWORD")]
    public uint dwPageStart;

    [NativeTypeName("DWORD")]
    public uint dwPageSize;

    [NativeTypeName("DWORD [1]")]
    public fixed uint dwOffset[1];
}
