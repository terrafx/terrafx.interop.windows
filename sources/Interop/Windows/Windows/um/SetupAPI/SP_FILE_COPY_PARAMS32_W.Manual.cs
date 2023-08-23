// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_FILE_COPY_PARAMS32_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public HSPFILEQ QueueHandle;

    [NativeTypeName("PCWSTR")]
    public char* SourceRootPath;

    [NativeTypeName("PCWSTR")]
    public char* SourcePath;

    [NativeTypeName("PCWSTR")]
    public char* SourceFilename;

    [NativeTypeName("PCWSTR")]
    public char* SourceDescription;

    [NativeTypeName("PCWSTR")]
    public char* SourceTagfile;

    [NativeTypeName("PCWSTR")]
    public char* TargetDirectory;

    [NativeTypeName("PCWSTR")]
    public char* TargetFilename;

    [NativeTypeName("DWORD")]
    public uint CopyStyle;

    public HINF LayoutInf;

    [NativeTypeName("PCWSTR")]
    public char* SecurityDescriptor;
}
