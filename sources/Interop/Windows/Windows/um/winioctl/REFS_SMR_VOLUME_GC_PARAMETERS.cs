// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct REFS_SMR_VOLUME_GC_PARAMETERS
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Flags;

    public REFS_SMR_VOLUME_GC_ACTION Action;

    public REFS_SMR_VOLUME_GC_METHOD Method;

    [NativeTypeName("DWORD")]
    public uint IoGranularity;

    [NativeTypeName("DWORD")]
    public uint CompressionFormat;

    [NativeTypeName("DWORDLONG [8]")]
    public fixed ulong Unused[8];
}
