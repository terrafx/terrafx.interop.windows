// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SPC_INDIRECT_DATA_CONTENT
    {
        [NativeTypeName("CRYPT_ATTRIBUTE_TYPE_VALUE")]
        public _CRYPT_ATTRIBUTE_TYPE_VALUE Data;

        [NativeTypeName("CRYPT_ALGORITHM_IDENTIFIER")]
        public _CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

        [NativeTypeName("CRYPT_HASH_BLOB")]
        public _CRYPTOAPI_BLOB Digest;
    }
}
