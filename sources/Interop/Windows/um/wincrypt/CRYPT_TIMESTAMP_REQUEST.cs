// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_TIMESTAMP_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        [NativeTypeName("CRYPT_DER_BLOB")]
        public CRYPT_DATA_BLOB HashedMessage;

        [NativeTypeName("LPSTR")]
        public sbyte* pszTSAPolicyId;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPT_DATA_BLOB Nonce;

        [NativeTypeName("BOOL")]
        public int fCertReq;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;
    }
}
