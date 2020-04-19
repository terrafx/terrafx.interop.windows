// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_KEY_ATTRIBUTES_INFO
    {
        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB KeyId;

        public CRYPT_BIT_BLOB IntendedKeyUsage;

        [NativeTypeName("PCERT_PRIVATE_KEY_VALIDITY")]
        public CERT_PRIVATE_KEY_VALIDITY* pPrivateKeyUsagePeriod;
    }
}
