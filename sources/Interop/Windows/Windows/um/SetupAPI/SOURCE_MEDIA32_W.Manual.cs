// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SOURCE_MEDIA32_W
{
    [NativeTypeName("PCWSTR")]
    public char* Reserved;

    [NativeTypeName("PCWSTR")]
    public char* Tagfile;

    [NativeTypeName("PCWSTR")]
    public char* Description;

    [NativeTypeName("PCWSTR")]
    public char* SourcePath;

    [NativeTypeName("PCWSTR")]
    public char* SourceFile;

    [NativeTypeName("DWORD")]
    public uint Flags;
}
