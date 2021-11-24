// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SP_DRVINSTALL_PARAMS32
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Rank;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD_PTR")]
    public nuint PrivateData;

    [NativeTypeName("DWORD")]
    public uint Reserved;
}
