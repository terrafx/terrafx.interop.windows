// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
public unsafe partial struct PSS_VA_SPACE_ENTRY
{
    public void* BaseAddress;

    public void* AllocationBase;

    [NativeTypeName("DWORD")]
    public uint AllocationProtect;

    [NativeTypeName("ULONG_PTR")]
    public nuint RegionSize;

    [NativeTypeName("DWORD")]
    public uint State;

    [NativeTypeName("DWORD")]
    public uint Protect;

    [NativeTypeName("DWORD")]
    public uint Type;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("DWORD")]
    public uint SizeOfImage;

    public void* ImageBase;

    [NativeTypeName("DWORD")]
    public uint CheckSum;

    [NativeTypeName("WORD")]
    public ushort MappedFileNameLength;

    [NativeTypeName("const wchar_t *")]
    public ushort* MappedFileName;
}
