// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CERT_SIGNED_CONTENT_INFO
    {
        [NativeTypeName("CRYPT_DER_BLOB")]
        public CRYPTOAPI_BLOB ToBeSigned;

        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        public CRYPT_BIT_BLOB Signature;
    }
}
