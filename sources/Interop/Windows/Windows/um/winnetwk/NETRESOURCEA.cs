// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct NETRESOURCEA
{
    [NativeTypeName("DWORD")]
    public uint dwScope;

    [NativeTypeName("DWORD")]
    public uint dwType;

    [NativeTypeName("DWORD")]
    public uint dwDisplayType;

    [NativeTypeName("DWORD")]
    public uint dwUsage;

    [NativeTypeName("LPSTR")]
    public sbyte* lpLocalName;

    [NativeTypeName("LPSTR")]
    public sbyte* lpRemoteName;

    [NativeTypeName("LPSTR")]
    public sbyte* lpComment;

    [NativeTypeName("LPSTR")]
    public sbyte* lpProvider;
}
