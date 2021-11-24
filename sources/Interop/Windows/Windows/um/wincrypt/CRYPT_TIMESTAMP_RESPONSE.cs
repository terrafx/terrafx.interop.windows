// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CRYPT_TIMESTAMP_RESPONSE
{
    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [NativeTypeName("DWORD")]
    public uint cFreeText;

    [NativeTypeName("LPWSTR *")]
    public ushort** rgFreeText;

    public CRYPT_BIT_BLOB FailureInfo;

    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB ContentInfo;
}
