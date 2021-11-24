// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CREDENTIALW
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint Type;

    [NativeTypeName("LPWSTR")]
    public ushort* TargetName;

    [NativeTypeName("LPWSTR")]
    public ushort* Comment;

    public FILETIME LastWritten;

    [NativeTypeName("DWORD")]
    public uint CredentialBlobSize;

    [NativeTypeName("LPBYTE")]
    public byte* CredentialBlob;

    [NativeTypeName("DWORD")]
    public uint Persist;

    [NativeTypeName("DWORD")]
    public uint AttributeCount;

    [NativeTypeName("PCREDENTIAL_ATTRIBUTEW")]
    public CREDENTIAL_ATTRIBUTEW* Attributes;

    [NativeTypeName("LPWSTR")]
    public ushort* TargetAlias;

    [NativeTypeName("LPWSTR")]
    public ushort* UserName;
}
