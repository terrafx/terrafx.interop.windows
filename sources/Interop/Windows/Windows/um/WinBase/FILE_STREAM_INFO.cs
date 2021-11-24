// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct FILE_STREAM_INFO
{
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    [NativeTypeName("DWORD")]
    public uint StreamNameLength;

    public LARGE_INTEGER StreamSize;

    public LARGE_INTEGER StreamAllocationSize;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort StreamName[1];
}
