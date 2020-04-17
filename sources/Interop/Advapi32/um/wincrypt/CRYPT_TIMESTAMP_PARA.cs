// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_TIMESTAMP_PARA
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* pszTSAPolicyId;

        [NativeTypeName("BOOL")]
        public int fRequestCerts;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPTOAPI_BLOB Nonce;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;
    }
}
