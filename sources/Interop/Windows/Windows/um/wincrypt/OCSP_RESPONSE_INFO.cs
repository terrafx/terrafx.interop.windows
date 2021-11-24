// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct OCSP_RESPONSE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;

    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Value;
}
