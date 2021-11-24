// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CANDIDATEINFO
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCount;

    [NativeTypeName("DWORD [32]")]
    public fixed uint dwOffset[32];

    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;
}
