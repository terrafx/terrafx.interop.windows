// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct OCSP_CERT_ID
    {
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPTOAPI_BLOB IssuerNameHash;

        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPTOAPI_BLOB IssuerKeyHash;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPTOAPI_BLOB SerialNumber;
    }
}
