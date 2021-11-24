// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SOURCE_MEDIA64_A
{
    [NativeTypeName("PCSTR")]
    public sbyte* Reserved;

    [NativeTypeName("PCSTR")]
    public sbyte* Tagfile;

    [NativeTypeName("PCSTR")]
    public sbyte* Description;

    [NativeTypeName("PCSTR")]
    public sbyte* SourcePath;

    [NativeTypeName("PCSTR")]
    public sbyte* SourceFile;

    [NativeTypeName("DWORD")]
    public uint Flags;
}
