// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct IMAGE_ENCLAVE_CONFIG64
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint MinimumRequiredConfigSize;

    [NativeTypeName("DWORD")]
    public uint PolicyFlags;

    [NativeTypeName("DWORD")]
    public uint NumberOfImports;

    [NativeTypeName("DWORD")]
    public uint ImportList;

    [NativeTypeName("DWORD")]
    public uint ImportEntrySize;

    [NativeTypeName("BYTE [16]")]
    public fixed byte FamilyID[16];

    [NativeTypeName("BYTE [16]")]
    public fixed byte ImageID[16];

    [NativeTypeName("DWORD")]
    public uint ImageVersion;

    [NativeTypeName("DWORD")]
    public uint SecurityVersion;

    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveSize;

    [NativeTypeName("DWORD")]
    public uint NumberOfThreads;

    [NativeTypeName("DWORD")]
    public uint EnclaveFlags;
}
