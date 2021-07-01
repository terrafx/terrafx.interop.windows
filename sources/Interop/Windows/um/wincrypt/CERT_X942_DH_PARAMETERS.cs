// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_X942_DH_PARAMETERS
    {
        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPTOAPI_BLOB p;

        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPTOAPI_BLOB g;

        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPTOAPI_BLOB q;

        [NativeTypeName("CRYPT_UINT_BLOB")]
        public CRYPTOAPI_BLOB j;

        [NativeTypeName("PCERT_X942_DH_VALIDATION_PARAMS")]
        public CERT_X942_DH_VALIDATION_PARAMS* pValidationParams;
    }
}
