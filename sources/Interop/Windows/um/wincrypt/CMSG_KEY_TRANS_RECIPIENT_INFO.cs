// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CMSG_KEY_TRANS_RECIPIENT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        public CERT_ID RecipientId;

        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB EncryptedKey;
    }
}
