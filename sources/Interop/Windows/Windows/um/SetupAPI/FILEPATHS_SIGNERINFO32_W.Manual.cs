// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct FILEPATHS_SIGNERINFO32_W
{
    [NativeTypeName("PCWSTR")]
    public char* Target;

    [NativeTypeName("PCWSTR")]
    public char* Source;

    public uint Win32Error;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("PCWSTR")]
    public char* DigitalSigner;

    [NativeTypeName("PCWSTR")]
    public char* Version;

    [NativeTypeName("PCWSTR")]
    public char* CatalogFile;
}
