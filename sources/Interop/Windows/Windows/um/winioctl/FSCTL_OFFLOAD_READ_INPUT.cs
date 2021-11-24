// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct FSCTL_OFFLOAD_READ_INPUT
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint TokenTimeToLive;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("DWORDLONG")]
    public ulong FileOffset;

    [NativeTypeName("DWORDLONG")]
    public ulong CopyLength;
}
